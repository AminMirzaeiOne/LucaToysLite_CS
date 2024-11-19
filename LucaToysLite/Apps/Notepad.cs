using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LucaToysLite.Controls;

namespace LucaToysLite.Apps
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

        RoundedButton downButton = null;

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            this.downButton = this.roundedButton1;
            this.ltContextMenu1.Show(this.roundedButton1, new Point(0,50));
        }

        private void ltContextMenu1_Opened(object sender, EventArgs e)
        {
            this.downButton.BackColor = System.Drawing.Color.Crimson;
        }

        private void ltContextMenu1_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            this.downButton.BackColor = System.Drawing.Color.FromArgb(10,10,10);
        }

        private void roundedButton2_MouseDown(object sender, MouseEventArgs e)
        {
            this.downButton = this.roundedButton2;
            this.ltContextMenu2.Show(this.roundedButton2, new Point(0, 50));
        }

        private void roundedButton3_MouseDown(object sender, MouseEventArgs e)
        {
            this.downButton = this.roundedButton3;
            this.ltContextMenu3.Show(this.roundedButton3, new Point(0, 50));

        }

        private void roundedButton4_MouseDown(object sender, MouseEventArgs e)
        {
            this.downButton = this.roundedButton4;
            this.ltContextMenu4.Show(this.roundedButton4, new Point(0, 50));
        }

        private void roundedButton5_MouseDown(object sender, MouseEventArgs e)
        {
            this.downButton = this.roundedButton5;
            this.ltContextMenu7.Show(this.roundedButton5, new Point(0, 50));
        }

        private void roundedButton16_MouseDown(object sender, MouseEventArgs e)
        {
            this.downButton = this.roundedButton16;
            this.ltContextMenu5.Show(this.roundedButton16, new Point(0, 50));
        }
    }
}
