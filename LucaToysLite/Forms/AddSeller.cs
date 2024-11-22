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
    public partial class AddSeller : Form
    {
        public AddSeller()
        {
            InitializeComponent();
            this.panel1.Controls.Add(this.important);

            this.important.Dock = DockStyle.Fill;

            this.important.Visible = true;
        }
        private LucaToysLite.Pages.AddSeller.Important important = new Pages.AddSeller.Important();

        private void roundedRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton1.Checked)
            {
                this.animator1.Show(this.important);
            }
        }
    }
}
