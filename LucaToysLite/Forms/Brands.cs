using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToysLite.Forms
{
    public partial class Brands : Form
    {
        public Brands()
        {
            InitializeComponent();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.AddBrand addBrand = new AddBrand();
            addBrand.Show();
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.BrandInfo brandInfo = new BrandInfo();
            brandInfo.Show();
        }
    }
}
