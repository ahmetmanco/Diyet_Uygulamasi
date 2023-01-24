using Data_Access_Layer.Context;
using System.Data;

namespace _03_UI
{
    public partial class Form3 : Form
    {
        Form1 baseForm;
        public Form3(Form1 form1)
        {
            InitializeComponent();
            baseForm = form1;
        }

        DiyetUygulamasiContext context;
        

        private void frm3_btnGirisYap_Click(object sender, EventArgs e)
        {
            context = new DiyetUygulamasiContext();

            var kontrol=context.Kullanicilar.Where(x=>x.Eposta==txtEposta.Text).ToList();

            if (kontrol.Count != 0)
            {
                if (kontrol.FirstOrDefault().Eposta == txtEposta.Text)
                {
                    bool kontrolsifre = (kontrol.FirstOrDefault().Sifre == txtSifre.Text) ? true : false;

                    if (kontrolsifre == true)
                    {
                        MessageBox.Show("Giriş Başarılı !");
                        Form4 frm4 = new Form4(kontrol.FirstOrDefault());
                        frm4.Show();
                        this.Hide();
                    }
                    else MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                }
            }
            else MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
            baseForm.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        //private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    Application.Exit();
        //}
    }
}
