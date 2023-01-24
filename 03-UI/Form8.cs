using Data_Access_Layer.Context;
using Entity.Enum;
using Microsoft.VisualBasic.ApplicationServices;

namespace _03_UI
{
    public partial class Form8 : Form
    {
        DiyetUygulamasiContext context;
        Form4 baseForm4;
        public Form8(Form4 form4)
        {
            InitializeComponent();
            baseForm4 = form4;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            DataDoldur();
            baseForm4.comboboxYemekdoldur(cmbYemekler);
            cmbYemekler.SelectedIndex = 1;
        }

        private void DataDoldur()
        {
            context = new DiyetUygulamasiContext();
            var yemekKiyasSorgu = from yemekOgun in context.YemekOgun
                                  join ogun in context.Ogunler on yemekOgun.OgunId equals ogun.OgunId
                                  join yemek in context.Yemekler on yemekOgun.YemekId equals yemek.YemekId
                                  select new { YemekAdi = yemek.YemekAdi, Ogun = ogun.OgunTipi };

            var yemekKiyasSonuc = from veri in yemekKiyasSorgu
                                  group veri by veri.Ogun into grup
                                  select new { OgunAdi = grup.Key, Sayisi = grup.Where(x => x.Ogun == grup.Key && x.YemekAdi == cmbYemekler.Text).Count() };


            var son = yemekKiyasSonuc.ToList();
            dgvYemekKiyas.DataSource = son;


            var yemekKiyasSorguTum = from yemekOgun in context.YemekOgun
                                  join ogun in context.Ogunler on yemekOgun.OgunId equals ogun.OgunId
                                  join yemek in context.Yemekler on yemekOgun.YemekId equals yemek.YemekId
                                  select new { YemekAdi = yemek.YemekAdi, Ogun = ogun.OgunTipi };

            var yemekKiyasSonucTum = from veri in yemekKiyasSorguTum
                                  group veri by veri.YemekAdi into grup
                                  select new { YemekAdi = grup.Key, Sayisi = grup.Where(x => x.YemekAdi == grup.Key).Count() };


            var sonTum = yemekKiyasSonucTum.ToList();
            dgvEnCok.DataSource = sonTum;
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            baseForm4.Show();
            this.Close();
        }

        private void cmbYemekler_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataDoldur();
        }
    }
}
