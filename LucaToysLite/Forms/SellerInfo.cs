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
    public partial class SellerInfo : Form
    {
        public SellerInfo()
        {
            InitializeComponent();

            this.panel1.Controls.Add(this.important);
            this.panel1.Controls.Add(this.photos);

            this.important.Dock = DockStyle.Fill;
            this.photos.Dock = DockStyle.Fill;

            this.important.Visible = true;
            this.photos.Visible = false;

        }

        private LucaToysLite.Pages.SellerInfo.Important important = new Pages.SellerInfo.Important();
        private LucaToysLite.Pages.SellerInfo.Photos photos = new Pages.SellerInfo.Photos();

        private void roundedRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton4.Checked)
            {
                this.important.Visible = false;
                this.animator1.Show(this.photos);
            }
        }

        private void roundedRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton1.Checked)
            {
                this.photos.Visible = false;
                this.animator1.Show(this.important);
            }
        }
    }
}
