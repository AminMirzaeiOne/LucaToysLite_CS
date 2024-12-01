using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToysLite.Menus
{
    public partial class Salesman : UserControl
    {
        public Salesman()
        {
            InitializeComponent();
        }

        private void roundedButton7_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.Brands brands = new Forms.Brands();
            brands.Show();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.Persons persons = new Forms.Persons();
            persons.Show();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.AddBrand addBrand = new Forms.AddBrand();
            addBrand.Show();
        }
    }
}
