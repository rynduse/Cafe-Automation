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
    public partial class frmMasalar : Form
    {
        public frmMasalar()
        {
            InitializeComponent();
        }

        private void btnMasa_Click(object sender, EventArgs e)
        {
            frmSiparisAl siparis = new frmSiparisAl();
            siparis.Show();
        }
    }
}
