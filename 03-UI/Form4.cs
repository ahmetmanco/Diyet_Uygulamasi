using Data_Access_Layer.Context;
using Entity;
using Entity.Enum;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;


namespace _03_UI
{
    public partial class Form4 : Form
    {

        DiyetUygulamasiContext context;
        Kullanici user;


        public Form4(Kullanici kullanici)
        {
            InitializeComponent();
            user = kullanici;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboboxYemekdoldur(cmbYemek);
            OgunleriListele();
            btnOguneYemekEkle.Enabled = false;
            btnOgunSil.Enabled = false;
        }

        private void btnOguneYemekEkle_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;   // Öğün bilgilerini gir groupbox ı açılsın

        }


        #region SORUN COZULDU
        // Burada onemli bir sorun var. SQL'de YemekOgun tablosuna ayni anda birden fazla ayni deger girilemiyor. Yani ben kahvaltida (OgunId = 1) cips (YemekId = 4) yedim. Sonra biraz daha yedigimde yani cipsi tekrar ekleyecegim zaman (1,4) degerinde giris yapamiyorum. Bunu cozmek icin YemekOgun'e id ekledim ve YemekOgunMapping'de buna primary key verdim.
        #endregion

        #region SORUN COZULDU
        // Yemeklerle ogunler yemekogun tablosunda baglantili degil. O baglantiyi yemek kaydet diyerek burada yapiyoruz. Ancak baglanti olmadigi icin de datagrid'e veri gelmiyor cunku YemekOgun tablosunda veri yok.
        #endregion
        private void btnYemekKaydet_Click(object sender, EventArgs e)
        {
            context = new DiyetUygulamasiContext();

            YemekOgun yemekOgun = new YemekOgun()
            {
                YemekId = cmbYemek.SelectedIndex + 1,
                OgunId = (int)dgvOgunler.SelectedRows[0].Cells[0].Value,    //???????
                Porsiyon = decimal.Parse(txtPorsiyon.Text)
            };

            context.YemekOgun.Add(yemekOgun);
            context.SaveChanges();

            OgunleriListele();
            OgundekiYemekleriListele();
            groupBox3.Visible = false;


        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOguneYemekEkle.Enabled = true;
        }

        private void dgvOgunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OgundekiYemekleriListele();
            btnOguneYemekEkle.Enabled = true;
            btnOgunSil.Enabled = true;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            user = null;
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOgunSil_Click(object sender, EventArgs e)
        {
            context = new DiyetUygulamasiContext();

            var silinecekOgunler = context.YemekOgun.Where(x => x.OgunId == (int)dgvOgunler.SelectedCells[0].Value)   // ??????????????
                .ToList();

            silinecekOgunler.ForEach(x => context.YemekOgun.Remove(x));
            context.Ogunler.Remove(context.Ogunler.Find((int)dgvOgunler.SelectedCells[0].Value));   // ?????????????????

            context.SaveChanges();

            OgunleriListele();
            OgundekiYemekleriListele();
        }
        private void btnYemekSil_Click(object sender, EventArgs e)
        {
            context = new DiyetUygulamasiContext();

            var silinecekYemekOgun = context.YemekOgun.Where(x => x.YemekOgunId == (int)dataGridView1.SelectedRows[0].Cells[0].Value).ToList();    //???????

            silinecekYemekOgun.ForEach(x => context.YemekOgun.Remove(x));  //????????

            context.SaveChanges();
            OgundekiYemekleriListele();

        }

        private void OgundekiYemekleriListele()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            context = new DiyetUygulamasiContext();

            var sanalTablo = context.YemekOgun.Join(context.Yemekler,
                                                   yo => yo.YemekId,
                                                   y => y.YemekId,
                                                   (yo, y) => new { y.YemekAdi, y.Kalori, yo.OgunId, yo.Porsiyon, yo.YemekOgunId })   // YemekOgunYemek tablosu => yoy
                                              .Join(context.Ogunler,
                                                   yoy => yoy.OgunId,
                                                   og => og.OgunId,
                                                   (yoy, og) =>
 /*bu satir, datagrid de gorunecek tablo*/    new
                                              {
                                                  yoy.YemekOgunId,
                                                  og.OgunId,
                                                  og.KullaniciId,
                                                  Tipi = og.OgunTipi.ToString(),
                                                  og.Tarih,
                                                  og.OgunNo,
                                                  yoy.YemekAdi,
                                                  Kalori = yoy.Kalori * yoy.Porsiyon
                                              })
              .Where(x => x.KullaniciId == user.Id &&
              x.OgunId == (int)dgvOgunler.SelectedRows[0].Cells[0].Value)    // ????????????????????
                                              .ToList();

            dataGridView1.DataSource = sanalTablo;
           
            
            dataGridView1.Columns["Tarih"].Width = 80;
            dataGridView1.Columns["OgunNo"].Width = 70;
            dataGridView1.Columns["Tipi"].Width = 120;
            dataGridView1.Columns["Kalori"].Width = 75;

            dataGridView1.Columns["OgunId"].Visible = false;
            dataGridView1.Columns["YemekOgunId"].Visible = false;
            dataGridView1.Columns["KullaniciId"].Visible = false;
        }

        private void OgunleriListele()
        {
            dgvOgunler.DataSource = null;
            dgvOgunler.Rows.Clear();

            // Tarihe gore gosterme eklenecek. (Yalnizca bugun yenilen ogunler gozuksun)
            context = new DiyetUygulamasiContext();

            var sanalTablo = context.Ogunler.Where(x => x.KullaniciId == user.Id && x.Tarih.Date.Day == DateTime.Now.Day).ToList();  

            dgvOgunler.DataSource = sanalTablo;

            dgvOgunler.Columns["OgunId"].Visible = false;
            dgvOgunler.Columns["KullaniciId"].Visible = false;
            dgvOgunler.Columns["Kullanici"].Visible = false;
            dgvOgunler.Columns["Yemek"].Visible = false;

            dgvOgunler.Columns["Tarih"].Width = 80;
            dgvOgunler.Columns["OgunNo"].Width = 70;
            dgvOgunler.Columns["OgunTipi"].Width = 120;
        }

        public void comboboxOgundoldur(ComboBox comboBox)
        {
            context = new DiyetUygulamasiContext();
            comboBox.DataSource = Enum.GetValues(typeof(OgunTipleri));
            comboBox.SelectedIndex = -1;
        }

        public void comboboxYemekdoldur(ComboBox comboBox)
        {
            context = new DiyetUygulamasiContext();
            comboBox.DataSource = context.Yemekler.ToList();
            comboBox.DisplayMember = "YemekAdi";
            comboBox.ValueMember = "YemekId";
            comboBox.SelectedIndex = -1;
        }


        private void btnYeniOgun_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(user);
            this.Hide();
            form5.Show();
        }
        private void btnGunSonuRaporu_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(this, user);    // Form4 olarak bu halini ve işlem yapan kullanıcıyı Form6 ya göndermiş olduk. 
            this.Hide();                      // Tekrar Form4 e dönebilmek için Hide
            form6.Show();
        }

        private void btnKiyasRaporu_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(this, user);
            this.Hide();
            form7.Show();
        }

        private void btnYemekCesidiRaporu_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(this);
            this.Hide();
            form8.Show();
        }
    }
}
