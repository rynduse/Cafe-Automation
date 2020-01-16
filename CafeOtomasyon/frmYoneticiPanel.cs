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
    public partial class frmYoneticiPanel : Form
    {
        public frmYoneticiPanel()
        {
            InitializeComponent();
        }

        private void btnYeniUrunKayit_Click(object sender, EventArgs e)
        {
            panelYonetici.Controls.Clear();
            frmYeniUrunKayit urunKayit = new frmYeniUrunKayit();
            urunKayit.TopLevel = false;
            panelYonetici.Controls.Add(urunKayit);
            urunKayit.Show();
            urunKayit.Dock = DockStyle.Fill;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GirisForm giris = new GirisForm();
            giris.Show();
        }

        private void btnGunlukCiro_Click(object sender, EventArgs e)
        {
            panelYonetici.Controls.Clear();
            frmGunlukCiro gunlukCiro = new frmGunlukCiro();
            gunlukCiro.TopLevel = false;
            panelYonetici.Controls.Add(gunlukCiro);
            gunlukCiro.Show();
            gunlukCiro.Dock = DockStyle.Fill;

        }

        private void btnSifreIslemi_Click(object sender, EventArgs e)
        {
            panelYonetici.Controls.Clear();
            frmSifreIslemi sifreIslemi = new frmSifreIslemi();
            sifreIslemi.TopLevel = false;
            panelYonetici.Controls.Add(sifreIslemi);
            sifreIslemi.Show();
            sifreIslemi.Dock = DockStyle.Fill;

        }
    }
}
