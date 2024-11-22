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

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.UpdateSeller updateSeller = new Forms.UpdateSeller();
            updateSeller.Show();
        }

        private void roundedButton5_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.AddCustomer addCustomer = new Forms.AddCustomer();
            addCustomer.Show();
        }

        private void roundedButton6_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.DeleteCustomer deleteCustomer = new Forms.DeleteCustomer();
            deleteCustomer.Show();
        }

        private void roundedButton7_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.UpdateCustomer updateCustomer = new Forms.UpdateCustomer();
            updateCustomer.Show();
        }
    }
}
