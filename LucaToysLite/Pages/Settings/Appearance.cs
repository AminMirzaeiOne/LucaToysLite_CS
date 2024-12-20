﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToysLite.Pages.Settings
{
    public partial class Appearance : UserControl
    {
        public Appearance()
        {
            InitializeComponent();
            this.panel1.Controls.Add(this.based);
            this.panel1.Controls.Add(this.fonts);
            this.panel1.Controls.Add(this.region);
            this.panel1.Controls.Add(this.sounds);
            this.panel1.Controls.Add(this.animations);

            this.based.Dock = DockStyle.Fill;
            this.fonts.Dock = DockStyle.Fill;
            this.region.Dock = DockStyle.Fill;
            this.sounds.Dock = DockStyle.Fill;
            this.animations.Dock = DockStyle.Fill;

            this.based.Visible = true;
            this.fonts.Visible = false;
            this.region.Visible = false;
            this.sounds.Visible = false;
            this.animations.Visible = false;
        }

        private LucaToysLite.Pages.Settings.AppearancePages.Based based = new AppearancePages.Based();
        private LucaToysLite.Pages.Settings.AppearancePages.Fonts fonts = new AppearancePages.Fonts();
        private LucaToysLite.Pages.Settings.AppearancePages.Region region = new AppearancePages.Region();
        private LucaToysLite.Pages.Settings.AppearancePages.Sounds sounds = new AppearancePages.Sounds();
        private LucaToysLite.Pages.Settings.AppearancePages.Animations animations = new AppearancePages.Animations();

        private void roundedRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton1.Checked)
            {
                this.fonts.Visible = false;
                this.region.Visible = false;
                this.sounds.Visible = false;
                this.animations.Visible = false;
                this.animator1.Show(this.based);
            }
        }

        private void roundedRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton3.Checked)
            {
                this.based.Visible = false;
                this.region.Visible = false;
                this.sounds.Visible = false;
                this.animations.Visible = false;
                this.animator1.Show(this.fonts);
            }
        }

        private void roundedRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if(this.roundedRadioButton4.Checked)
            {
                this.fonts.Visible = false;
                this.based.Visible = false;
                this.sounds.Visible = false;
                this.animations.Visible = false;
                this.animator1.Show(this.region);
            }
        }

        private void roundedRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton2.Checked)
            {
                this.fonts.Visible = false;
                this.based.Visible = false;
                this.region.Visible = false;
                this.animations.Visible = false;
                this.animator1.Show(this.sounds);
            }
        }

        private void roundedRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton5.Checked)
            {
                this.fonts.Visible = false;
                this.based.Visible = false;
                this.region.Visible = false;
                this.sounds.Visible = false;
                this.animator1.Show(this.animations);
            }
        }
    }
}
