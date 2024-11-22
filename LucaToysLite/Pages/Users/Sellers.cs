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
    public partial class Sellers : UserControl
    {
        public Sellers()
        {
            InitializeComponent();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.AddSeller addSeller = new Forms.AddSeller();
            addSeller.Show();
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.SellerInfo sellerInfo = new Forms.SellerInfo();
            sellerInfo.Show();
        }
    }
}
