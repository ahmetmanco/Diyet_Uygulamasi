using Data_Access_Layer.Context;
using Entity;
using Entity.Enum;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;

namespace _03_UI
{
    public partial class Form5 : Form
    {
        Kullanici kullanici;
        DiyetUygulamasiContext context;
        Form4 baseForm;


        public Form5(Kullanici user)
        {
            InitializeComponent();
            kullanici = user;

            Form4 form4 = new Form4(kullanici);
            form4.comboboxOgundoldur(cmbTipi);
            form4.comboboxYemekdoldur(cmbYemek);

            baseForm = form4;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //OgunTipleri status;
            Enum.TryParse<OgunTipleri>(cmbTipi.SelectedValue.ToString(), out OgunTipleri status);

            Ogun yeniOgun = new Ogun()
            {
                KullaniciId = kullanici.Id,
                Tarih = dtpTarih.Value,
                OgunNo = OgunNoHesapla(),
                OgunTipi = status,
            };


            context.Ogunler.Add(yeniOgun);
            context.SaveChanges();


            YemekOgun yemekOgun = new YemekOgun()
            {
                YemekId = cmbYemek.SelectedIndex + 1,
                OgunId = yeniOgun.OgunId,
                Porsiyon = decimal.Parse(txtPorsiyon.Text),
                
            };

            context.YemekOgun.Add(yemekOgun);
            context.SaveChanges();

            Form4 frm4 = new Form4(kullanici);
            this.Close();
            frm4.Show();
        }


        private int OgunNoHesapla()   // ????????????
        {
            context = new DiyetUygulamasiContext();
            int numara;

            if (context.Ogunler.Where(x => x.Tarih == DateTime.Now.Date &&  x.KullaniciId == kullanici.Id).OrderBy(x => x.OgunNo).LastOrDefault() != null)
            {
                numara = (int)context.Ogunler.Where(x => x.Tarih == DateTime.Now.Date)
                    .OrderBy(x => x.OgunNo)
                    .LastOrDefault().OgunNo + 1;
                return numara;
            }

            else
                return numara = 1;
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            baseForm.Show();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
           // Application.Exit();      // uygulamayı kapatıyor.  Kullanmayacağız !!!
        }
    }
}

