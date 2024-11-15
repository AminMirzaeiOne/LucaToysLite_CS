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
            this.version.Dock = DockStyle.Fill;
            
        }

        private LucaToysLite.Pages.About.Version version = new Pages.About.Version();

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
    }
}
