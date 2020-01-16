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
    public partial class frmSiparisGoster : Form
    {
        public frmSiparisGoster()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            var ent = new CafeOtomasyonEntities();
            var sonuc = from Urun in ent.SiparisUrun select Urun;
            dgvSiparisGoster.DataSource = sonuc.ToList();
        }
    }
}
