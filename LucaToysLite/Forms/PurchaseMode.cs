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
    public partial class PurchaseMode : Form
    {
        public PurchaseMode()
        {
            InitializeComponent();
            this.panel1.Controls.Add(this.fixedCustomer);
            this.panel1.Controls.Add(this.variousCustomer);
            this.panel2.Controls.Add(this.toysList);
            this.panel2.Controls.Add(this.dollsList);

            this.fixedCustomer.Dock = DockStyle.Fill;
            this.variousCustomer.Dock = DockStyle.Fill;
            this.toysList.Dock = DockStyle.Fill;
            this.dollsList.Dock = DockStyle.Fill;

            this.fixedCustomer.Visible = true;
            this.variousCustomer.Visible = false;
            this.toysList.Visible = true;
            this.dollsList.Visible = true;
        }
        private LucaToysLite.Panels.Purchase.FixedCustomer fixedCustomer = new Panels.Purchase.FixedCustomer();
        private LucaToysLite.Panels.Purchase.VariousCustomer variousCustomer = new Panels.Purchase.VariousCustomer();
        private LucaToysLite.Panels.Purchase.ToysList toysList = new Panels.Purchase.ToysList();
        private LucaToysLite.Panels.Purchase.DollsList dollsList = new Panels.Purchase.DollsList();

        private void roundedRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton2.Checked)
            {
                this.variousCustomer.Visible = false;
                this.animator1.Show(this.fixedCustomer);
            }
        }

        private void roundedRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton4.Checked)
            {
                this.fixedCustomer.Visible = false;
                this.animator1.Show(this.variousCustomer);
            }
        }

        private void roundedRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(this.roundedRadioButton3.Checked)
            {
                this.dollsList.Visible = false;
                this.animator1.Show(this.toysList);
            }
        }

        private void roundedRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton1.Checked)
            {
                this.toysList.Visible = false;
                this.animator1.Show(this.dollsList);
            }
        }
    }
}
