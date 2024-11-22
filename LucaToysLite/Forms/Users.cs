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

            this.sellers.Dock = DockStyle.Fill;

            this.sellers.Visible = true;
        }
        private LucaToysLite.Pages.Users.Sellers sellers = new Pages.Users.Sellers();

        private void roundedRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(this.roundedRadioButton1.Checked)
                this.animator1.Show(this.sellers);
        }
    }
}
