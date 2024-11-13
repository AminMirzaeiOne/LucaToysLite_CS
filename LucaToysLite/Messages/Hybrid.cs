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

        public Hybrid(string title, string content)
        {
            InitializeComponent();
            this.TitleText = title;
            this.ContentText = content;
        }

        public Hybrid(string title, string content, string description)
        {
            InitializeComponent();
            this.TitleText = title;
            this.ContentText = content;
            this.DescriptionText = description;
        }

        public Hybrid(string title, string content, string description, Image icon)
        {
            InitializeComponent();
            this.TitleText = title;
            this.ContentText = content;
            this.DescriptionText = description;
            this.MessageIcon = icon;
        }

        public Hybrid(string title, string content, string description, LucaToysLite.Controls.LTMessageBox.IconTypes type)
        {
            InitializeComponent();
            this.TitleText = title;
            this.ContentText = content;
            this.DescriptionText = description;
            switch (type)
            {
                case LucaToysLite.Controls.LTMessageBox.IconTypes.Error:
                    this.MessageIcon = Properties.Resources.icons8_error_96;
                    break;
                case LucaToysLite.Controls.LTMessageBox.IconTypes.Warning:
                    this.MessageIcon = Properties.Resources.icons8_warning_96;
                    break;
                case LucaToysLite.Controls.LTMessageBox.IconTypes.Information:
                    this.MessageIcon = Properties.Resources.icons8_info_96;
                    break;
            }
            this.IconType = type;
        }

        public Hybrid(string title, string content, string description, LucaToysLite.Controls.LTMessageBox.ActionTypes action)
        {
            InitializeComponent();
            this.TitleText = title;
            this.ContentText = content;
            this.DescriptionText = description;

            switch (action)
            {
                case LucaToysLite.Controls.LTMessageBox.ActionTypes.Close:
                    this.MessageIcon = Properties.Resources.icons8_close_window_96;
                    this.DefaultButtonText = "Yes";
                    this.ButtonTwoText = "No";
                    this.ButtonThree = false;
                    break;
                case LucaToysLite.Controls.LTMessageBox.ActionTypes.Exit:
                    this.MessageIcon = Properties.Resources.icons8_exit_96;
                    this.DefaultButtonText = "Yes";
                    this.ButtonTwoText = "No";
                    this.ButtonThree = false;
                    break;
                case LucaToysLite.Controls.LTMessageBox.ActionTypes.Restart:
                    this.MessageIcon = Properties.Resources.icons8_restart_96;
                    this.DefaultButtonText = "Yes";
                    this.ButtonTwoText = "No";
                    this.ButtonThree = false;
                    break;
            }
            this.ActionType = action;
        }



        private LucaToysLite.Controls.LTMessageBox.ActionTypes actionType = LucaToysLite.Controls.LTMessageBox.ActionTypes.None;
        private LucaToysLite.Controls.LTMessageBox.IconTypes iconType = LucaToysLite.Controls.LTMessageBox.IconTypes.None;
        private LucaToysLite.Controls.LTMessageBox.StartSounds soundType = LucaToysLite.Controls.LTMessageBox.StartSounds.None;

        public event EventHandler DefaultButtonAction;
        public event EventHandler ButtonTwoAction;
        public event EventHandler ButtonThreeAction;

        public LucaToysLite.Controls.LTMessageBox.ActionTypes ActionType
        {
            get { return this.actionType; }
            set { this.actionType = value; }
        }

        public LucaToysLite.Controls.LTMessageBox.StartSounds SoundType
        {
            get { return this.soundType; }
            set { this.soundType = value; }
        }

        public LucaToysLite.Controls.LTMessageBox.IconTypes IconType
        {
            get { return this.iconType; }
            set { this.iconType = value; }
        }

        public System.Drawing.Color ColorPallet
        {
            get { return this.roundedButton1.BackColor; }
            set
            {
                this.roundedButton1.BackColor = value;
                this.roundedButton2.FlatAppearance.BorderColor = value;
                this.roundedButton3.FlatAppearance.BorderColor = value;
                this.windowToolbar1.ColorPalette = value;

            }
        }

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
                this.windowToolbar1.Close();
            else if (this.ActionType != LucaToysLite.Controls.LTMessageBox.ActionTypes.None)
            {
                switch (this.ActionType)
                {
                    case LucaToysLite.Controls.LTMessageBox.ActionTypes.Close:
                        this.Owner.Close();
                        break;
                    case LucaToysLite.Controls.LTMessageBox.ActionTypes.Exit:
                        System.Windows.Forms.Application.Exit();
                        break;
                    case LucaToysLite.Controls.LTMessageBox.ActionTypes.Restart:
                        System.Windows.Forms.Application.Restart();
                        break;
                }
            }
            else
                this.DefaultButtonAction(null, null);
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            if (this.ButtonTwoAction == null)
                this.windowToolbar1.Close();
            else
                this.ButtonTwoAction(null, null);
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            if (this.ButtonThreeAction == null)
                this.windowToolbar1.Close();
            else
                this.ButtonThreeAction(null, null);
        }

        private void copyContentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.label2.Text);
        }

        private void copyDescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.label1.Text);

        }

        private void searchContentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"https://www.google.com/search?q={this.label2.Text}");
        }

        private void searchDescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"https://www.google.com/search?q={this.label1.Text}");

        }
    }
}
