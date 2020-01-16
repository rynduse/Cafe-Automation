using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyon
{
    public partial class frmYeniUrunKayit : Form
    {
        public frmYeniUrunKayit()
        {
            InitializeComponent();
        }
        Urunler urun = new Urunler();


   

        private void btnListele_Click(object sender, EventArgs e)
        {
            var ent = new CafeOtomasyonEntities();
            var sonuc = from Urun in ent.Urunler select new { Urun.urunAdi, Urun.birimFiyat, Urun.kalanAdet };
            dgvListele.DataSource = sonuc.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            urun.kategoriID = Convert.ToInt32(txtKategori.Text);
            urun.birimFiyat = Convert.ToDecimal(txtUrunFiyat.Text);
            urun.urunAdi = txtUrunAdi.Text;
            urun.satilanAdet = 0;
            urun.kalanAdet = Convert.ToInt32(txtStok.Text);


            using (CafeOtomasyonEntities ent = new CafeOtomasyonEntities())
            {
                ent.Urunler.Add(urun);
                ent.SaveChanges();
            }
        }
    }
}
