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
    public partial class Products : UserControl
    {
        public Products()
        {
            InitializeComponent();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.Products products = new Forms.Products();
            products.Show();
        }

        private void roundedButton8_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.SearchProduct searchProduct = new Forms.SearchProduct();
            searchProduct.Show();
        }
    }
}
