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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();

            this.panel1.Controls.Add(this.important);
            this.panel1.Controls.Add(this.unnecessary);
            this.panel1.Controls.Add(this.description);

            this.important.Dock = DockStyle.Fill;
            this.unnecessary.Dock = DockStyle.Fill;
            this.description.Dock = DockStyle.Fill;

            this.important.Visible = true;
            this.unnecessary.Visible = false;
            this.description.Visible = false;

        }

        private LucaToysLite.Pages.AddCustomer.Important important = new Pages.AddCustomer.Important();
        private LucaToysLite.Pages.AddCustomer.Unnecessary unnecessary = new Pages.AddCustomer.Unnecessary();
        private LucaToysLite.Pages.AddCustomer.Description description = new Pages.AddCustomer.Description();

        private void roundedRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton1.Checked)
            {
                this.unnecessary.Visible = false;
                this.description.Visible = false;
                this.animator1.Show(this.important);
            }
        }

        private void roundedRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton2.Checked)
            {
                this.important.Visible = false;
                this.description.Visible = false;
                this.animator1.Show(this.unnecessary);
            }
        }

        private void roundedRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton3.Checked)
            {
                this.important.Visible = false;
                this.unnecessary.Visible = false;
                this.animator1.Show(this.description);
            }
        }
    }
}
