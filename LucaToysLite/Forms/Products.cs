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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();

            this.panel1.Controls.Add(this.toys);
            this.panel1.Controls.Add(this.dolls);
            this.panel1.Controls.Add(this.sundry);

            this.toys.Dock = DockStyle.Fill;
            this.dolls.Dock = DockStyle.Fill;
            this.sundry.Dock = DockStyle.Fill;

            this.toys.Visible = true;
            this.dolls.Visible = false;
            this.sundry.Visible = false;


        }

        private LucaToysLite.Pages.Product.Toys toys = new Pages.Product.Toys();
        private LucaToysLite.Pages.Product.Dolls dolls = new Pages.Product.Dolls();
        private LucaToysLite.Pages.Product.Sundry sundry = new Pages.Product.Sundry();

        private void roundedRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton1.Checked)
            {
                this.dolls.Visible = false;
                this.sundry.Visible = false;
                this.animator1.Show(this.toys);
            }
        }

        private void roundedRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton2.Checked)
            {
                this.toys.Visible = false;
                this.sundry.Visible = false;
                this.animator1.Show(this.dolls);
            }
        }

        private void roundedRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton3.Checked)
            {
                this.dolls.Visible = false;
                this.toys.Visible = false;
                this.animator1.Show(this.sundry);
            }
        }
    }
}
