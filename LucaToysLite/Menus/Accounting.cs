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
    public partial class Accounting : UserControl
    {
        public Accounting()
        {
            InitializeComponent();
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.PurchaseMode purchaseMode = new Forms.PurchaseMode();
            purchaseMode.Show();
        }

        private void roundedButton7_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.Accounts accounts = new Forms.Accounts();
            accounts.Show();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.AddAccount addAccount = new Forms.AddAccount();
            addAccount.Show();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.DeleteAccount deleteAccount = new Forms.DeleteAccount();
            deleteAccount.Show();
        }
    }
}
