﻿using System;
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

        public Hybrid()
        {
            InitializeComponent();
            this.FocusEnable(this.Owner);
        }

        public Hybrid(Form owner,string title, string content)
        {
            InitializeComponent();
            this.Owner = owner;
            this.TitleText = title;
            this.ContentText = content;
            this.windowToolbar1.CloseMessage = false;
            this.FocusEnable(this.Owner);
        }

        public Hybrid(Form owner,string title, string content, string description)
        {
            InitializeComponent();
            this.Owner= owner;
            this.TitleText = title;
            this.ContentText = content;
            this.DescriptionText = description;
            this.windowToolbar1.CloseMessage = false;
            this.FocusEnable(this.Owner);

        }

        public Hybrid(Form owner,string title, string content, string description, Image icon)
        {
            InitializeComponent();
            this.Owner = owner;
            this.TitleText = title;
            this.ContentText = content;
            this.DescriptionText = description;
            this.MessageIcon = icon;
            this.windowToolbar1.CloseMessage = false;
            this.FocusEnable(this.Owner);

        }

        public Hybrid(Form owner, string title, string content, string description, LucaToysLite.Controls.LTMessageBox.IconTypes type)
        {
            InitializeComponent();
            this.Owner = owner;
            this.TitleText = title;
            this.ContentText = content;
            this.DescriptionText = description;
            this.IconType = type;
            this.windowToolbar1.CloseMessage = false;
            this.FocusEnable(this.Owner);

        }

        public Hybrid(Form owner,string title, string content, string description, LucaToysLite.Controls.LTMessageBox.ActionTypes action)
        {
            InitializeComponent();
            this.Owner = owner;
            this.TitleText = title;
            this.ContentText = content;
            this.DescriptionText = description;
            this.ActionType = action;
            this.windowToolbar1.CloseMessage = false;
            this.FocusEnable(this.Owner);

        }

        public Hybrid(Form owner,string title, string content, string description, System.Drawing.Image icon, LucaToysLite.Controls.LTMessageBox.StartSounds sound)
        {
            InitializeComponent();
            this.Owner = owner;
            this.TitleText = title;
            this.ContentText = content;
            this.DescriptionText = description;
            this.MessageIcon = icon;
            this.SoundType = sound;
            this.windowToolbar1.CloseMessage = false;
            this.FocusEnable(this.Owner);

        }

        public Hybrid(Form owner, string title, string content, string description, LucaToysLite.Controls.LTMessageBox.IconTypes icon, LucaToysLite.Controls.LTMessageBox.StartSounds sound)
        {
            InitializeComponent();
            this.Owner = owner;
            this.TitleText = title;
            this.ContentText = content;
            this.DescriptionText = description;
            this.IconType = icon;
            this.SoundType = sound;
            this.windowToolbar1.CloseMessage = false;
            this.FocusEnable(this.Owner);

        }

        public Hybrid(Form owner,string title, string content, string description, LucaToysLite.Controls.LTMessageBox.ActionTypes action, LucaToysLite.Controls.LTMessageBox.StartSounds sound)
        {
            InitializeComponent();
            this.Owner = owner;
            this.TitleText = title;
            this.ContentText = content;
            this.DescriptionText = description;
            this.ActionType = action;
            this.SoundType = sound;
            this.windowToolbar1.CloseMessage = false;
            this.FocusEnable(this.Owner);

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
            set
            {
                this.actionType = value;
                switch (value)
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
            }
        }

        public LucaToysLite.Controls.LTMessageBox.StartSounds SoundType
        {
            get { return this.soundType; }
            set
            {
                this.soundType = value;
                switch (value)
                {
                    case LucaToysLite.Controls.LTMessageBox.StartSounds.DSound:
                        this.windowToolbar1.StartupSound = LucaToysLite.Controls.WindowToolbar.StartupSounds.DSound;
                        break;
                    case LucaToysLite.Controls.LTMessageBox.StartSounds.CSound:
                        this.windowToolbar1.StartupSound = LucaToysLite.Controls.WindowToolbar.StartupSounds.CSound;
                        break;
                    case LucaToysLite.Controls.LTMessageBox.StartSounds.GSound:
                        this.windowToolbar1.StartupSound = LucaToysLite.Controls.WindowToolbar.StartupSounds.GSound;
                        break;
                }
            }
        }

        public LucaToysLite.Controls.LTMessageBox.IconTypes IconType
        {
            get { return this.iconType; }
            set
            {
                this.iconType = value;
                switch (value)
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
            }
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
            switch (this.ActionType)
            {
                case LucaToysLite.Controls.LTMessageBox.ActionTypes.None:
                    if (this.DefaultButtonAction != null)
                        this.DefaultButtonAction(null, null);
                    break;
                case LucaToysLite.Controls.LTMessageBox.ActionTypes.Close:
                    if (this.Owner != null)
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

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            switch (this.ActionType)
            {
                case LucaToysLite.Controls.LTMessageBox.ActionTypes.None:
                    if (this.ButtonTwoAction != null)
                        this.ButtonTwoAction(null, null);
                    break;
                case LucaToysLite.Controls.LTMessageBox.ActionTypes.Close:
                case LucaToysLite.Controls.LTMessageBox.ActionTypes.Exit:
                case LucaToysLite.Controls.LTMessageBox.ActionTypes.Restart:
                    this.windowToolbar1.Close();
                    this.ActiveOwner();
                    break;
            }
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            switch (this.ActionType)
            {
                case LucaToysLite.Controls.LTMessageBox.ActionTypes.None:
                    if (this.ButtonThreeAction != null)
                        this.ButtonThreeAction(null, null);
                    break;
                case LucaToysLite.Controls.LTMessageBox.ActionTypes.Close:
                case LucaToysLite.Controls.LTMessageBox.ActionTypes.Exit:
                case LucaToysLite.Controls.LTMessageBox.ActionTypes.Restart:
                    this.windowToolbar1.Close();
                    this.ActiveOwner();
                    break;
            }
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
