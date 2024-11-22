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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            this.panel1.Controls.Add(this.sellers);
            this.panel1.Controls.Add(this.customers);

            this.sellers.Dock = DockStyle.Fill;
            this.customers.Dock = DockStyle.Fill;

            this.sellers.Visible = true;
            this.customers.Visible = false;
        }
        private LucaToysLite.Pages.Users.Sellers sellers = new Pages.Users.Sellers();
        private LucaToysLite.Pages.Users.Customers customers = new Pages.Users.Customers();

        private void roundedRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton1.Checked)
            {
                this.customers.Visible = false;
                this.animator1.Show(this.sellers);
            }
        }

        private void roundedRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton2.Checked)
            {
                this.sellers.Visible = false;
                this.animator1.Show(this.customers);
            }
        }
    }
}
