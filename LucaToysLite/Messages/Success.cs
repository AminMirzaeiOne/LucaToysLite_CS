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
            this.FocusEnable(this.Owner);
        }

        private void Success_Load(object sender, EventArgs e)
        {
            this.loadingControl1.StartProgress();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            this.windowToolbar1.Close();
            this.ActiveOwner();
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

        private void ActiveOwner()
        {
            FormWindowState windowState = FormWindowState.Normal;
            windowState = this.Owner.WindowState;
            this.Owner.WindowState = FormWindowState.Minimized;
            this.Owner.WindowState = windowState;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            this.frm.Close();
        }

        public Success(Form owner, string title, string content)
        {
            InitializeComponent();
            this.Owner = owner;
            this.TitleText = title;
            this.ContentText = content;
            this.windowToolbar1.CloseMessage = false;
            this.FocusEnable(this.Owner);
        }

        public Success(Form owner, string title, string content, string description)
        {
            InitializeComponent();
            this.Owner = owner;
            this.TitleText = title;
            this.ContentText = content;
            this.DescriptionText = description;
            this.windowToolbar1.CloseMessage = false;
            this.FocusEnable(this.Owner);

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
