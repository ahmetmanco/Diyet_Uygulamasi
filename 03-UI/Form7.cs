using Data_Access_Layer.Context;
using Entity;
using Entity.Enum;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace _03_UI
{
    public partial class Form7 : Form
    {
        DiyetUygulamasiContext context;
        Form4 baseForm4;
        Kullanici user;

        public Form7(Form4 form4, Kullanici kullanici)
        {
            InitializeComponent();
            baseForm4 = form4;         // Form4 e geri dönebilmek için
            user = kullanici;
        }

        DiyetUygulamasiContext ctx;

        private void Form7_Load(object sender, EventArgs e)
        {
            ctx = new DiyetUygulamasiContext();
            comboboxOgundoldur(cmbOgunTipi);
            

        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
            baseForm4.Show();
        }

        public void comboboxOgundoldur(ComboBox comboBox)
        {
            context = new DiyetUygulamasiContext();
            comboBox.DataSource = Enum.GetValues(typeof(OgunTipleri));
            comboBox.SelectedIndex = -1; // DUZELT!!! -1
        }

        public void OgunBilgileriGetir()
        {
            context = new DiyetUygulamasiContext();

            var raporHaftalik = from yemekOgun in ctx.YemekOgun
                                from ogun in ctx.Ogunler.Where(x => x.OgunId == yemekOgun.OgunId && x.Tarih.Day <= DateTime.Now.Day & x.Tarih.Day >= DateTime.Now.Day - 7 && x.KullaniciId == user.Id)
                                from yemek in ctx.Yemekler.Where(x => x.YemekId == yemekOgun.YemekId)
                                from kullanici in ctx.Kullanicilar.Where(x => x.Id == user.Id)
                                where (ogun.OgunTipi == (OgunTipleri)cmbOgunTipi.SelectedIndex + 1)
                                // OgunTipi ve tarihi ayniysa kaloriyi toplayacak

                                select new
                                {
                                    Tarih = ogun.Tarih,
                                    OgunAdi = ogun.OgunTipi,
                                    Kalori = (yemek.Kalori * yemekOgun.Porsiyon)
                                };

            var sonucHaftalik = from veri in raporHaftalik
                        group veri by veri.OgunAdi into Grup
                        select new
                        {
                            OgunAdi = Grup.Key,
                            Kalori = Grup.Where(x => x.OgunAdi == (OgunTipleri)cmbOgunTipi.SelectedIndex + 1 && x.Tarih.Day <= DateTime.Now.Day && x.Tarih.Day >= DateTime.Now.Day - 7).Sum(x => x.Kalori)
                        };

            dataGridView1.DataSource = sonucHaftalik.OrderByDescending(x => x.OgunAdi).ToList();


            var raporAylik = from yemekOgun in ctx.YemekOgun
                                from ogun in ctx.Ogunler.Where(x => x.OgunId == yemekOgun.OgunId && x.Tarih.Month == DateTime.Now.Month && x.KullaniciId == user.Id)
                                from yemek in ctx.Yemekler.Where(x => x.YemekId == yemekOgun.YemekId)
                                from kullanici in ctx.Kullanicilar.Where(x => x.Id == user.Id)
                                where (ogun.OgunTipi == (OgunTipleri)cmbOgunTipi.SelectedIndex + 1)
                                // OgunTipi ve tarihi ayniysa kaloriyi toplayacak

                                select new
                                {
                                    Tarih = ogun.Tarih,
                                    OgunAdi = ogun.OgunTipi,
                                    Kalori = (yemek.Kalori * yemekOgun.Porsiyon)
                                };

            var sonucAylik = from veri in raporAylik
                        group veri by veri.OgunAdi into Grup
                        select new
                        {
                            OgunAdi = Grup.Key,
                            Kalori = Grup.Where(x => x.OgunAdi == (OgunTipleri)cmbOgunTipi.SelectedIndex + 1 && x.Tarih.Month == DateTime.Now.Month).Sum(x => x.Kalori)
                        };

            dataGridView2.DataSource = sonucAylik.OrderByDescending(x => x.OgunAdi).ToList();


            var raporHaftalikTum = from yemekOgun in ctx.YemekOgun
                                from ogun in ctx.Ogunler.Where(x => x.OgunId == yemekOgun.OgunId && x.Tarih.Day <= DateTime.Now.Day & x.Tarih.Day >= DateTime.Now.Day - 7)
                                from yemek in ctx.Yemekler.Where(x => x.YemekId == yemekOgun.YemekId)
                                where (ogun.OgunTipi == (OgunTipleri)cmbOgunTipi.SelectedIndex + 1)
                                // OgunTipi ve tarihi ayniysa kaloriyi toplayacak

                                select new
                                {
                                    Tarih = ogun.Tarih,
                                    OgunAdi = ogun.OgunTipi,
                                    Kalori = (yemek.Kalori * yemekOgun.Porsiyon)
                                };

            var sonucHaftalikTum = from veri in raporHaftalikTum
                                group veri by veri.OgunAdi into Grup
                                select new
                                {
                                    OgunAdi = Grup.Key,
                                    Kalori = Grup.Where(x => x.OgunAdi == (OgunTipleri)cmbOgunTipi.SelectedIndex + 1 && x.Tarih.Day <= DateTime.Now.Day && x.Tarih.Day >= DateTime.Now.Day - 7).Sum(x => x.Kalori)
                                };


            dgvHaftalikTum.DataSource = sonucHaftalikTum.OrderByDescending(x => x.OgunAdi).ToList();

            var raporAylikTum = from yemekOgun in ctx.YemekOgun
                             from ogun in ctx.Ogunler.Where(x => x.OgunId == yemekOgun.OgunId && x.Tarih.Month == DateTime.Now.Month)
                             from yemek in ctx.Yemekler.Where(x => x.YemekId == yemekOgun.YemekId)
                             where (ogun.OgunTipi == (OgunTipleri)cmbOgunTipi.SelectedIndex + 1)
                             // OgunTipi ve tarihi ayniysa kaloriyi toplayacak

                             select new
                             {
                                 Tarih = ogun.Tarih,
                                 OgunAdi = ogun.OgunTipi,
                                 Kalori = (yemek.Kalori * yemekOgun.Porsiyon)
                             };

            var sonucAylikTum = from veri in raporAylikTum
                             group veri by veri.OgunAdi into Grup
                             select new
                             {
                                 OgunAdi = Grup.Key,
                                 Kalori = Grup.Where(x => x.OgunAdi == (OgunTipleri)cmbOgunTipi.SelectedIndex + 1 && x.Tarih.Month == DateTime.Now.Month).Sum(x => x.Kalori)
                             };

            dgvAylikTum.DataSource = sonucAylikTum.OrderByDescending(x => x.OgunAdi).ToList();





        }

        private void cmbOgunTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            OgunBilgileriGetir();
        }
    }
}
