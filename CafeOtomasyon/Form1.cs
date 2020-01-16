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
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            //database baglantili clas ile baglanti kurulma islemi yapilacak gerekli metot ya da sp cagrilacak
            // urunler tablosuna ekleme metodu 


        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmYoneticiGiris frmYonetici = new frmYoneticiGiris();
            frmYonetici.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();// uygulamadan cikis
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPersonel personel =new frmPersonel();
            personel.Show();
            this.Hide();
        }
    }
}