using Data_Access_Layer.Context;
using Entity;
using System.Data;

namespace _03_UI
{
    public partial class Form2 : Form
    {
        DiyetUygulamasiContext ctx = new DiyetUygulamasiContext();
        Form1 baseForm;



        public Form2(Form1 form1)
        {
            InitializeComponent();
            baseForm = form1;
        }




        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string kontrolSonucu = FormKontrol(txtSifre.Text, txtSifreTekrar.Text, txtEposta.Text);

            if (kontrolSonucu == "")
            {
                KullaniciEkle(txtAd.Text, txtSoyad.Text, txtEposta.Text, txtTelNo.Text, txtSifre.Text);
                MessageBox.Show("Kullanıcı kaydı başarıyla oluşturulmuştur.");
            }

            else
                MessageBox.Show(kontrolSonucu);
        }

        /// <summary>
        /// Kullanıcıyı giriş yapacağı forma yönlendiren metot.
        /// </summary>
        private void formGiriseAtla()
        {
            Form3 frm3 = new Form3(baseForm);
            frm3.Show();
            this.Close();
        }

        /// <summary>
        /// Kullanıcının girdiği bilgilerin gereklilikleri karşılayıp karşılamadığını kontrol eden metot.
        /// </summary>
        /// <param name="sifre"></param>
        /// <param name="sifreTekrar"></param>
        /// <param name="eposta"></param>
        /// <returns></returns>
        public string FormKontrol(string sifre, string sifreTekrar, string eposta)
        {
            string sonuc = "";

            foreach (Control kontrol in gbKayitPaneli.Controls)
            {
                if (kontrol is TextBox && kontrol.Text == "")
                    sonuc = "Tüm alanların doldurulması zorunludur!";

                if (kontrol is CheckBox && ((kontrol as CheckBox).Checked) == false)
                    sonuc = "Sözleşmelerin kabul edilmesi zorunludur!";
            }

            if (sonuc == "")
            {
                string sifreSonuc = SifreKontrol(sifre, sifreTekrar);
                if (sifreSonuc.Length > 0)
                    sonuc = sifreSonuc;
            }

            if (sonuc == "")
            {
                string epostaSonuc = EpostaKontrol(eposta);
                if (epostaSonuc.Length > 0)
                    sonuc = epostaSonuc;
            }

            return sonuc;
        }

        /// <summary>
        /// Kullanıcının oluşturduğu şirenin uygun olup olmadığını sorgulayan metot.
        /// </summary>
        /// <param name="sifre"></param>
        /// <param name="sifreTekrar"></param>
        /// <returns></returns>
        private string SifreKontrol(string sifre, string sifreTekrar)
        {
            string sonuc = "";

            if (sifre != sifreTekrar)
            {
                sonuc = "Girilen şifreler aynı olmalıdır!";
            }

            if ((sifre == sifreTekrar) && sifre.Length <= 5)
            {
                sonuc = "Şifreniz en az 6 karakterden oluşmalıdır!";
            }

            return sonuc;
        }

        /// <summary>
        /// Kullanıcının girdiği e-posta adresinin sistemde kayıtlı olup olmadığını sorgulayan metot.
        /// </summary>
        /// <param name="eposta"></param>
        /// <returns></returns>
        private string EpostaKontrol(string eposta)
        {
            string sonuc = "";
            var epostaMevcutMu = ctx.Kullanicilar.Where(x => x.Eposta == eposta).ToList();

            if (epostaMevcutMu.Count == 0)
                sonuc = "";

            else
            {
                sonuc = "Bu e-posta adresi sistemde kayıtlıdır! Lütfen başka bir e-posta adresi giriniz.";
                epostaMevcutMu = null;
            }

            return sonuc;
        }

        /// <summary>
        /// Parametre olarak verilen kullanıcı bilgileri ile yeni bir kullanıcı oluşturan metot.
        /// </summary>
        /// <param name="ad"></param>
        /// <param name="soyad"></param>
        /// <param name="eposta"></param>
        /// <param name="telefon"></param>
        /// <param name="sifre"></param>
        private void KullaniciEkle(string ad, string soyad, string eposta, string telefon, string sifre)
        {
            Kullanici user = new Kullanici();

            user.Ad = ad;
            user.Soyad = soyad;
            user.Eposta = eposta;
            user.Telefon = telefon;
            user.Sifre = sifre;

            ctx.Kullanicilar.Add(user);
            ctx.SaveChanges();

            formGiriseAtla();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
            baseForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.hangikredi.com/kullanici-sozlesmesi");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.microsoft.com");
        }
    }
}
