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
    public partial class About : UserControl
    {
        public About()
        {
            InitializeComponent();
        }

        private void roundedButton6_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.About about = new Forms.About();
            about.Show();
        }
    }
}
