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
        public Hybrid()
        {
            InitializeComponent();
        }

        public System.String TitleText { get { return this.windowToolbar1.TitleText; } set { this.windowToolbar1.TitleText = value; } }
        public System.String ContentText { get { return this.label2.Text; } set { this.label2.Text = value; } }
        public System.String DescriptionText { get { return this.label1.Text; } set { this.label1.Text = value; } }
        public System.Drawing.Image MessageIcon { get { return this.pictureBox1.BackgroundImage; } set { this.pictureBox1.BackgroundImage = value; } }

        public System.Boolean ButtonTwo { get { return this.roundedButton2.Visible; } set { this.roundedButton2.Visible = value; } }
        public System.Boolean ButtonThree { get { return this.roundedButton3.Visible; } set { this.roundedButton3.Visible = value; } }

        public System.String DefaultButtonText { get { return this.roundedButton1.Text; } set { this.roundedButton1.Text = value; } }
        public System.String ButtonTwoText { get { return this.roundedButton2.Text; } set { this.roundedButton2.Text = value; } }
    }
}
