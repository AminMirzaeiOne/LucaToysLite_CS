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
    public partial class BarcodeCreator : Form
    {
        public BarcodeCreator()
        {
            InitializeComponent();
            this.panel1.Controls.Add(this.barcodeCreator);
            this.panel1.Controls.Add(this.output);

            this.barcodeCreator.Visible = true;
            this.output.Visible = false;
        }

        private LucaToysLite.Pages.BarcodeCreator.Based barcodeCreator = new Pages.BarcodeCreator.Based();
        private LucaToysLite.Pages.BarcodeCreator.Output output = new Pages.BarcodeCreator.Output();


        private void roundedButton7_Click(object sender, EventArgs e)
        {

        }

        private void roundedRadioButton33_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton33.Checked) 
            {
                this.output.Visible = false;
                this.animator1.Show(this.barcodeCreator);
            }
        }

        private void roundedPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedRadioButton34_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton34.Checked)
            {
                this.barcodeCreator.Visible = false;
                this.animator1.Show(this.output);
            }
        }
    }
}
