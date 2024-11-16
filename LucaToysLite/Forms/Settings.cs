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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            this.panel1.Controls.Add(this.appearance);

            this.appearance.Dock = DockStyle.Fill;
        }
        private LucaToysLite.Pages.Settings.Appearance appearance = new Pages.Settings.Appearance();

        private void roundedRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton1.Checked)
                this.appearance.BringToFront();
        }
    }
}
