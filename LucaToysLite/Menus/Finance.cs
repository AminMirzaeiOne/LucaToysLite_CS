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
    public partial class Finance : UserControl
    {
        public Finance()
        {
            InitializeComponent();
        }

        private void roundedButton5_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.SoldToys soldToys = new Forms.SoldToys();
            soldToys.Show();
        }

        private void roundedButton6_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.SoldDolls soldDolls = new Forms.SoldDolls();
            soldDolls.Show();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.Performance performance = new Forms.Performance();
            performance.Show();
        }
    }
}
