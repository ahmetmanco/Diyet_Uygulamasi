using Data_Access_Layer.Context;
using Entity;

namespace _03_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DiyetUygulamasiContext context;


        private void Form1_Load(object sender, EventArgs e)
        {
            context = new DiyetUygulamasiContext();
            if (context.Yemekler.Count() == 0)
            {
                KategoriDoldur();
                YemekDoldur();
            }
        }


        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            Form2 frm2= new Form2(this);
            frm2.Show();
            this.Hide();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(this);
            frm3.Show();
            this.Hide();
        }

       
        private void YemekDoldur()
        {
            YemekEkle("Kayýsý", 1, 0.25m);
            YemekEkle("Yoðurt", 5, 0.33m);
            YemekEkle("Ekmek", 4, 0.66m);
            YemekEkle("Cips", 6, 1.28m);
            YemekEkle("Tavuk Göðsü", 3,100);
            YemekEkle("Muz", 1, 100);
            YemekEkle("Domates", 2, 0.33m);
            YemekEkle("Yumurta", 3, 0.66m);
            YemekEkle("Kýzarmýþ Patates", 2, 2.5m);
            YemekEkle("Badem", 7, 0.5m);
            YemekEkle("Simit", 8, 1.3m);
            YemekEkle("Taze Fasülye", 2,5);
        }

        private void KategoriDoldur()
        {
            KategoriEkle("Meyveler", "");
            KategoriEkle("Sebzeler", "");
            KategoriEkle("Hayvansal Gýda", "");
            KategoriEkle("Ekmek", "");
            KategoriEkle("Süt Ürünleri", "");
            KategoriEkle("Cips", "");
            KategoriEkle("Kuruyemiþ", "");
            KategoriEkle("Kahvaltýlýk", "");
        }

        private void KategoriEkle(string kategoriAdi, string kategoriAciklama)
        {
            Kategori yeniKategori = new Kategori()
            {
                KategoriAdi = kategoriAdi,
                Aciklama = kategoriAciklama
            };

            context.Kategoriler.Add(yeniKategori);
            context.SaveChanges();
        }

        private void YemekEkle(string adi, int kategori, decimal kalori)
        {
            Yemek yeniYemek = new Yemek()
            {
                YemekAdi = adi,
                KategoriId = kategori,
                Kalori = kalori
            };

            context.Yemekler.Add(yeniYemek);
            context.SaveChanges();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}