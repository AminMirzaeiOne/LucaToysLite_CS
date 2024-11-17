using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToysLite.Pages.Settings
{
    public partial class Appearance : UserControl
    {
        public Appearance()
        {
            InitializeComponent();
            this.panel1.Controls.Add(this.based);

            this.based.Dock = DockStyle.Fill;

            this.based.Visible = false;
        }

        private LucaToysLite.Pages.Settings.AppearancePages.Based based = new AppearancePages.Based();

        private void roundedRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton1.Checked)
            {
                this.animator1.Show(this.based);
            }
        }

        private void roundedRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(this.roundedRadioButton3.Checked)
                this.animator1.Hide(this.based);
        }
    }
}
