using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToysLite.Messages
{
    public partial class Hybrid : Form
    {
        public enum MessageTypes
        {
            Error, Info, Warningk
        }
        public Hybrid()
        {
            InitializeComponent();
        }

        public Hybrid()
        {
            InitializeComponent();
        }

        public event EventHandler DefaultButtonAction;
        public event EventHandler ButtonTwoAction;
        public event EventHandler ButtonThreeAction;

        public System.String TitleText { get { return this.windowToolbar1.TitleText; } set { this.windowToolbar1.TitleText = value; } }
        public System.String ContentText { get { return this.label2.Text; } set { this.label2.Text = value; } }
        public System.String DescriptionText { get { return this.label1.Text; } set { this.label1.Text = value; } }
        public System.Drawing.Image MessageIcon { get { return this.pictureBox1.BackgroundImage; } set { this.pictureBox1.BackgroundImage = value; } }

        public System.Boolean ButtonTwo { get { return this.roundedButton2.Visible; } set { this.roundedButton2.Visible = value; } }
        public System.Boolean ButtonThree { get { return this.roundedButton3.Visible; } set { this.roundedButton3.Visible = value; } }

        public System.String DefaultButtonText { get { return this.roundedButton1.Text; } set { this.roundedButton1.Text = value; } }
        public System.String ButtonTwoText
        {
            get { return this.roundedButton2.Text; }
            set
            {
                this.roundedButton2.Text = value;
                if (value == "")
                    this.ButtonTwo = false;
                else
                    this.ButtonTwo = true;
            }
        }
        public System.String ButtonThreeText
        {
            get { return this.roundedButton3.Text; }
            set
            {
                this.roundedButton3.Text = value;
                if (value == "")
                    this.ButtonThree = false;
                else
                    this.ButtonThree = true;
            }
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            if (this.DefaultButtonAction == null)
                this.Close();
            else
                this.DefaultButtonAction(null, null);
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            if (this.ButtonTwoAction == null)
                this.Close();
            else
                this.ButtonTwoAction(null, null);
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            if (this.ButtonThreeAction == null)
                this.Close();
            else
                this.ButtonThreeAction(null, null);
        }
    }
}
