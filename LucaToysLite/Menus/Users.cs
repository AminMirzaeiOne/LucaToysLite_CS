using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToysLite.Menus
{
    public partial class Users : UserControl
    {
        public Users()
        {
            InitializeComponent();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.Users users = new Forms.Users();
            users.Show();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.AddSeller addSeller = new Forms.AddSeller();
            addSeller.Show();
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.DeleteSeller deleteSeller = new Forms.DeleteSeller();
            deleteSeller.Show();
        }
    }
}
