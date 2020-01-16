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
    public partial class frmSiparisAl : Form
    {
        public frmSiparisAl()
        {
            InitializeComponent();

        }
        DataTable tablo = new DataTable();
        CafeOtomasyonEntities ent = new CafeOtomasyonEntities();
        private void frmSiparisAl_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("URUN ID", typeof(int));
            tablo.Columns.Add("ÜRÜN ADI", typeof(string));
            tablo.Columns.Add("FİYAT", typeof(string));

            dataGridView2.DataSource = tablo;




        }
        private void pbKahvalti_Click_1(object sender, EventArgs e)
        {

            tablo.Clear();
            dataGridView2.DataSource = tablo;

            var sonuc = from urun in ent.Urunler select new { urun.urunID, urun.urunAdi, urun.birimFiyat, urun.kategoriID };
            lbGorunmez.Text = "2";
            foreach (var item in sonuc)
            {
                if (item.kategoriID == 2)
                    tablo.Rows.Add(item.urunID, item.urunAdi, item.birimFiyat);

                dataGridView2.DataSource = tablo;
            }
        }

        private void pbAperatifler_Click_1(object sender, EventArgs e)
        {
            tablo.Clear();
            dataGridView2.DataSource = tablo;
            var sonuc = from urun in ent.Urunler select new { urun.urunID, urun.urunAdi, urun.birimFiyat, urun.kategoriID };
            lbGorunmez.Text = "3";
            foreach (var item in sonuc)
            {
                if (item.kategoriID == 3)
                    tablo.Rows.Add(item.urunID, item.urunAdi, item.birimFiyat);

                dataGridView2.DataSource = tablo;
            }
        }

        private void pbSalatalar_Click_1(object sender, EventArgs e)
        {
            tablo.Clear();
            dataGridView2.DataSource = tablo;
            var sonuc = from urun in ent.Urunler select new { urun.urunID, urun.urunAdi, urun.birimFiyat, urun.kategoriID };
            lbGorunmez.Text = "6";
            foreach (var item in sonuc)
            {
                if (item.kategoriID == 6)
                    tablo.Rows.Add(item.urunID, item.urunAdi, item.birimFiyat);

                dataGridView2.DataSource = tablo;
            }
        }

        private void pbTatlilar_Click_1(object sender, EventArgs e)
        {
            tablo.Clear();
            dataGridView2.DataSource = tablo;
            var sonuc = from urun in ent.Urunler select new { urun.urunID, urun.urunAdi, urun.birimFiyat, urun.kategoriID };
            lbGorunmez.Text = "5";
            foreach (var item in sonuc)
            {
                if (item.kategoriID == 5)
                    tablo.Rows.Add(item.urunID, item.urunAdi, item.birimFiyat);

                dataGridView2.DataSource = tablo;
            }
        }

        private void pbİcecekler_Click_1(object sender, EventArgs e)
        {
            tablo.Clear();
            dataGridView2.DataSource = tablo;
            var sonuc = from urun in ent.Urunler select new { urun.urunID, urun.urunAdi, urun.birimFiyat, urun.kategoriID };
            lbGorunmez.Text = "4";
            foreach (var item in sonuc)
            {
                if (item.kategoriID == 4)
                    tablo.Rows.Add(item.urunID, item.urunAdi, item.birimFiyat);

                dataGridView2.DataSource = tablo;
            }
        }

        private void pbAnaYemek_Click(object sender, EventArgs e)
        {
            tablo.Clear();
            dataGridView2.DataSource = tablo;

            var sonuc = from urun in ent.Urunler select new { urun.urunID, urun.urunAdi, urun.birimFiyat, urun.kategoriID };
            lbGorunmez.Text = "1";
            foreach (var item in sonuc)
            {

                if (item.kategoriID == 1)
                    tablo.Rows.Add(item.urunID, item.urunAdi, item.birimFiyat);

                dataGridView2.DataSource = tablo;
            }
        }
        decimal sonfiyat = 0;
        decimal toplamHesap = 0;
        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {


            string urunEklemeID = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            //decimal hesap = 0;
            var sonuc = from urun in ent.Urunler select new { urun.urunID, urun.urunAdi, urun.birimFiyat, urun.kategoriID };
            foreach (var item in sonuc)
            {

                if (item.kategoriID == Convert.ToInt32(lbGorunmez.Text))

                    lbHesapGosterim.Items.Add(item.urunAdi + " " + item.birimFiyat + " x " + txtMiktar.Text);
                // hesap += (decimal)item.birimFiyat * Convert.ToDecimal(txtMiktar.Text);
                if (dataGridView2.SelectedCells.Count > 0)
                {
                    decimal para = Convert.ToDecimal(dataGridView2.SelectedRows[0].Cells["FİYAT"].Value);
                    decimal miktar = Convert.ToInt32(txtMiktar.Text);
                    sonfiyat = (para * miktar);


                }


            }
            toplamHesap += sonfiyat;
            //txtHesap.Text = hesap.ToString();
            txtHesap.Text = toplamHesap.ToString();
        }
        SiparisUrun siparis = new SiparisUrun();
       // Adisyon ads = new Adisyon();
        private void btnSiparisOnay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sipariş alındı","Sipariş Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            //ads.masaNo = Convert.ToInt32(txtMasaNo.Text);
            siparis.adisyonNo = Convert.ToInt32(txtMasaNo.Text);
            siparis.urunID = Convert.ToInt32(txtUrunID.Text);
            siparis.adet = Convert.ToInt32(txtMiktar.Text);

            using (CafeOtomasyonEntities ent = new CafeOtomasyonEntities())
            {
                ent.SiparisUrun.Add(siparis);
                ent.SaveChanges();
            }
        }
    }
}
