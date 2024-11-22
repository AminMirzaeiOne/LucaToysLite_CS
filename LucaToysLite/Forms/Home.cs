using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            LTMessageBox.Show(this, "Maxelite", "Hello Maxelite", "Android or Windows Base Is Linux", LTMessageBox.ActionTypes.Close);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
           
        }

    }
}
