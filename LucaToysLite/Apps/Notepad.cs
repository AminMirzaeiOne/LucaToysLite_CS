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
    }
}
