using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LucaToysLite.Controls;

namespace LucaToysLite.Forms
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.panel1.Controls.Add(this.version);
            this.panel1.Controls.Add(this.license);
            this.panel1.Controls.Add(this.developer);
            this.panel1.Controls.Add(this.update);
            this.version.Dock = DockStyle.Fill;
            this.license.Dock = DockStyle.Fill;
            this.developer.Dock = DockStyle.Fill;
            this.update.Dock = DockStyle.Fill;

        }

        private LucaToysLite.Pages.About.Version version = new Pages.About.Version();
        private LucaToysLite.Pages.About.License license = new Pages.About.License();
        private LucaToysLite.Pages.About.Developer developer = new Pages.About.Developer();
        private LucaToysLite.Pages.About.Update update = new Pages.About.Update();

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void multiPage1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roundedRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(this.roundedRadioButton1.Checked)
                this.version.BringToFront();
        }

        private void roundedRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton2.Checked)
                this.license.BringToFront();
        }

        private void roundedRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton3.Checked)
                this.update.BringToFront();
        }

        private void roundedRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton4.Checked)
                this.developer.BringToFront();
        }
    }
}
