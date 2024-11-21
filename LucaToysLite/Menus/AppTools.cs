﻿using System;
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
    public partial class AppTools : UserControl
    {
        public AppTools()
        {
            InitializeComponent();
        }

        private void roundedButton5_Click(object sender, EventArgs e)
        {
            LucaToysLite.Apps.Calculator calculator = new Apps.Calculator();
            calculator.Show();
        }

        private void roundedButton7_Click(object sender, EventArgs e)
        {
            LucaToysLite.Apps.Notepad notepad = new Apps.Notepad();
            notepad.Show();
        }
    }
}