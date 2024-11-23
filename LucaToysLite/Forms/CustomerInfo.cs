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
    public partial class CustomerInfo : Form
    {
        public CustomerInfo()
        {
            InitializeComponent();

            this.panel1.Controls.Add(this.important);
            this.panel1.Controls.Add(this.unnecessary);
            this.panel1.Controls.Add(this.description);
            this.panel1.Controls.Add(this.photos);
            this.panel1.Controls.Add(this.lateral);

            this.important.Dock = DockStyle.Fill;
            this.unnecessary.Dock = DockStyle.Fill;
            this.description.Dock = DockStyle.Fill;
            this.photos.Dock = DockStyle.Fill;
            this.lateral.Dock = DockStyle.Fill;

            this.important.Visible = true;
            this.unnecessary.Visible = false;
            this.description.Visible = false;
            this.photos.Visible = false;
            this.lateral.Visible = false;


        }

        private LucaToysLite.Pages.CustomerInfo.Important important = new Pages.CustomerInfo.Important();
        private LucaToysLite.Pages.CustomerInfo.Unnecessary unnecessary = new Pages.CustomerInfo.Unnecessary();
        private LucaToysLite.Pages.CustomerInfo.Description description = new Pages.CustomerInfo.Description();
        private LucaToysLite.Pages.CustomerInfo.Photos photos = new Pages.CustomerInfo.Photos();
        private LucaToysLite.Pages.CustomerInfo.Lateral lateral = new Pages.CustomerInfo.Lateral();

        private void roundedRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton1.Checked)
            {
                this.photos.Visible = false;
                this.unnecessary.Visible = false;
                this.description.Visible = false;
                this.lateral.Visible = false;
                this.animator1.Show(this.important);
            }
        }

        private void roundedRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton2.Checked)
            {
                this.photos.Visible = false;
                this.important.Visible = false;
                this.description.Visible = false;
                this.lateral.Visible = false;
                this.animator1.Show(this.unnecessary);
            }
        }

        private void roundedRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton3.Checked)
            {
                this.photos.Visible = false;
                this.important.Visible = false;
                this.unnecessary.Visible = false;
                this.lateral.Visible = false;
                this.animator1.Show(this.description);
            }
        }

        private void roundedRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton4.Checked)
            {
                this.important.Visible = false;
                this.unnecessary.Visible = false;
                this.description.Visible = false;
                this.lateral.Visible = false;
                this.animator1.Show(this.photos);
            }
        }

        private void roundedRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton5.Checked)
            {
                this.photos.Visible = false;
                this.important.Visible = false;
                this.unnecessary.Visible = false;
                this.description.Visible = false;
                this.animator1.Show(this.lateral);
            }
        }
    }
}
