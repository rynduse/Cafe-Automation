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
    public partial class frmYoneticiGiris : Form
    {
        public frmYoneticiGiris()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GirisForm frm1 = new GirisForm();
            frm1.ShowDialog();

        }
        CafeOtomasyonEntities ent = new CafeOtomasyonEntities();    
        private void btnGirisYap_Click(object sender, EventArgs e)
        {

            var sonuc = from yonetim in ent.Yonetim select new { yonetim.kullaniciAdi, yonetim.sifre };

            foreach (var item in sonuc)
            {

                if (txtKullaniciAdi.Text == item.kullaniciAdi && txtKullaniciSifre.Text == item.sifre.ToString())
                {
                    frmYoneticiGiris.ActiveForm.Hide();
                    frmYoneticiPanel frmYonetici = new frmYoneticiPanel();
                    frmYonetici.Show();

                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı ve Şifre Hatalı");
                }
            }

        }

        private void txtKullaniciAdi_Enter_1(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.LightPink;
        }

        private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.White;
        }


    }
}
