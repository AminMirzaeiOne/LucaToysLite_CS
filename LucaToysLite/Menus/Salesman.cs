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
    public partial class Salesman : UserControl
    {
        public Salesman()
        {
            InitializeComponent();
        }

        private void roundedButton7_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.Brands brands = new Forms.Brands();
            brands.Show();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.Persons persons = new Forms.Persons();
            persons.Show();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.AddBrand addBrand = new Forms.AddBrand();
            addBrand.Show();
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.AddPerson addPerson = new Forms.AddPerson();
            addPerson.Show();
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.DeleteBrand deleteBrand = new Forms.DeleteBrand();
            deleteBrand.Show();
        }

        private void roundedButton5_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.DeletePerson deletePerson = new Forms.DeletePerson();
            deletePerson.Show();
        }

        private void roundedButton6_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.UpdateBrand updateBrand = new Forms.UpdateBrand();
            updateBrand.Show();
        }

        private void roundedButton8_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.UpdatePerson updatePerson = new Forms.UpdatePerson();
            updatePerson.Show();
        }
    }
}
