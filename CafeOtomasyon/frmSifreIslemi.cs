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
    public partial class frmSifreIslemi : Form
    {
        public frmSifreIslemi()
        {
            InitializeComponent();
        }
        CafeOtomasyonEntities ent = new CafeOtomasyonEntities();
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            // textBox1 = şuanki kAdi , textBox2 = yeni KAdi , textBox4 = yeni şifre
            var guncelle = ent.Yonetim.Where(s => s.kullaniciAdi == txtEskiKullanici.Text).First();

            guncelle.kullaniciAdi = txtYeniKullanici.Text;
            guncelle.sifre = Convert.ToInt32(txtSifreTekrar.Text);
            if (txtSifreTekrar.Text == txtyeniSifre.Text)
            {
                ent.SaveChanges();
                MessageBox.Show("Güncelleme İşlemi Başarılı","Sifre Guncelleme", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Yazdığınız Şifreler Eşleşmiyor");
            }
        }
    }
}
