﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LucaToysLite.ClassLibrary;
using LucaToysLite.Controls;
using LucaToysLite.Messages;

namespace LucaToysLite.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LTUpdateMessage.Show(this, "Messi", "Ronaldo", "Hello I Am Amin Mirzaei");
        }

        private void roundedButton1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void roundedButton1_MouseLeave(object sender, EventArgs e)
        {
            this.roundedButton1.Location = new Point(this.roundedButton1.Location.X, 737);
        }

        private void roundedButton1_MouseEnter(object sender, EventArgs e)
        {
            this.roundedButton1.Location = new Point(this.roundedButton1.Location.X, 704);
        }
    }
}
