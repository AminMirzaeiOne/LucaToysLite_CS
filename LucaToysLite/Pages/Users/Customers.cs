using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToysLite.Pages.Users
{
    public partial class Customers : UserControl
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.CustomerInfo customerInfo = new Forms.CustomerInfo();
            customerInfo.Show();
        }
    }
}
