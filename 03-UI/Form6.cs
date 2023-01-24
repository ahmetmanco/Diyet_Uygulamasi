using Data_Access_Layer.Context;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_UI
{
    public partial class Form6 : Form
    {

        Form4 baseForm4;
        Kullanici user;


        public Form6(Form4 form4, Kullanici kullanici)
        {
            InitializeComponent();
            baseForm4 = form4;         // Form4 e geri dönebilmek için
            user = kullanici;        // Form4 ten gelen user
        }
       
        DiyetUygulamasiContext ctx;

        private void Form6_Load(object sender, EventArgs e)
        {
           ctx = new DiyetUygulamasiContext();

            var result = ctx.Yemekler
              .Join(ctx.YemekOgun,
                    y => y.YemekId,
                    yo => yo.YemekId,
                    (y, yo) => new { y.Kalori, yo.Porsiyon, yo.OgunId })
              .Join(ctx.Ogunler,
                    yyo => yyo.OgunId,
                    o => o.OgunId,
                    (yyo, o) => new
                    {
                        yyo.OgunId,
                        o.KullaniciId,
                        o.OgunTipi,
                        o.Tarih,
                        Kalori = (yyo.Kalori * yyo.Porsiyon)
                    })
              .Where(x=>x.KullaniciId == user.Id  && x.Tarih == DateTime.Now.Date)
              .ToList();



            dataGridView1.DataSource = result;

            dataGridView1.Columns["KullaniciId"].Visible = false;  // dataGrid'in kolonlarındaki "KullaniciId" kolonunun görünürlüğünü kapattık
            dataGridView1.Columns["OgunId"].Visible = false;
            dataGridView1.Columns[2].Name = "Toplam Kalori";  // Kolon ismi değiştirme
                //  ÇALIŞMIYOR BU SATIR

        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
            baseForm4.Show();
        }
    }
}
