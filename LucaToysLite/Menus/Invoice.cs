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
    public partial class Invoice : UserControl
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void roundedButton5_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.ManagerInvoice managerInvoice = new Forms.ManagerInvoice();
            managerInvoice.Show();
        }
    }
}
