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
    public partial class frmPersonel : Form
    {
        public frmPersonel()
        {
            InitializeComponent();
        }

        private void btnMasa_Click(object sender, EventArgs e)
        {
            frmSiparisAl siparisAl = new frmSiparisAl();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GirisForm giris = new GirisForm();
            giris.Show();

        }

        private void frmPersonel_Load(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            frmMasalar masalar = new frmMasalar();
            masalar.TopLevel = false;
            panel3.Controls.Add(masalar);
            masalar.Show();
            masalar.Dock = DockStyle.Fill;
        }

        private void btnGunlukCiro_Click(object sender, EventArgs e)
        {
            this.Hide();
            GirisForm giris = new GirisForm();
            giris.Show();
        }

        private void btnSifreIslemi_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            frmSiparisGoster siparisGoster = new frmSiparisGoster();
            siparisGoster.TopLevel = false;
            panel3.Controls.Add(siparisGoster);
            siparisGoster.Show();
            siparisGoster.Dock = DockStyle.Fill;
        }

        private void btnMasalar_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            frmMasalar masalar = new frmMasalar();
            masalar.TopLevel = false;
            panel3.Controls.Add(masalar);
            masalar.Show();
            masalar.Dock = DockStyle.Fill;
        }
    }
}
