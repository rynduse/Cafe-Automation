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
    public partial class frmGunlukCiro : Form
    {
        CafeOtomasyonEntities entity = new CafeOtomasyonEntities();
        public frmGunlukCiro()
        {
            InitializeComponent();
        }

        private void frmGunlukCiro_Load(object sender, EventArgs e)
        {
            var sonuc = from s in entity.Satis select s;
            dataGridView1.DataSource = sonuc.ToList();

        }
    }
}
