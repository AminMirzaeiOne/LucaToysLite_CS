using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToysLite.Controls
{
    public partial class WindowToolbar : UserControl
    {
        private bool mouseDown;
        private Point lastLocation;

        public WindowToolbar()
        {
            InitializeComponent();
        }

        public System.Windows.Forms.Form Window { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.Window != null) 
                this.Window.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Window != null)
            {
                if (this.Window.WindowState == FormWindowState.Normal)
                {
                    this.button2.Text = "";
                    this.Window.WindowState = FormWindowState.Maximized;
                }
                else if(this.Window.WindowState == FormWindowState.Maximized)
                {
                    this.button2.Text = "";
                    this.Window.WindowState = FormWindowState.Normal;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.Window != null)
                this.Window.WindowState = FormWindowState.Minimized;
        }

        private void WindowToolbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mouseDown == true)
            {
                this.Location = new Point(
                (this.Location.X - this.lastLocation.X) + e.X, (this.Location.Y - this.lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void WindowToolbar_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseDown = true;
            this.lastLocation = e.Location;
        }

        private void WindowToolbar_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseDown = false;
        }
    }
}
