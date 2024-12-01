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
    public partial class Success : Form
    {
        public Success()
        {
            InitializeComponent();
        }

        private void Success_Load(object sender, EventArgs e)
        {
            this.loadingControl1.StartProgress();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            this.windowToolbar1.Close();
        }

        private Form frm = new Form();
        public void FocusEnable(Form window)
        {

            this.frm.FormBorderStyle = FormBorderStyle.None;
            this.frm.BackColor = Color.Black;
            this.frm.Opacity = 0.6;
            this.frm.Show();
            this.frm.Location = window.Location;
            this.frm.Size = window.Size;

        }

        public System.String TitleText
        {
            get { return this.windowToolbar1.TitleText; }
            set { this.windowToolbar1.TitleText = value; }
        }

        public System.String ContentText
        {
            get { return this.windowToolbar1.TitleText; }
            set { this.windowToolbar1.TitleText = value; }
        }

        public System.String DescriptionText
        {
            get { return this.windowToolbar1.TitleText; }
            set { this.windowToolbar1.TitleText = value; }
        }

        
    }
}
