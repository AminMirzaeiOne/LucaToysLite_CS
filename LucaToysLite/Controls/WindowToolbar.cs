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
        public System.Boolean MaximizeButton { get { return this.roundedButton2.Visible; } set { this.roundedButton2.Visible = value; } }
        public System.Boolean MinimizeButton { get { return this.roundedButton3.Visible; } set { this.roundedButton3.Visible = value; } }
        public System.Boolean MoveOption { get; set; } = true;
        public System.Boolean IconButton { get { return this.roundedButton4.Visible; } set { this.roundedButton4.Visible = value; } }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Window != null)
                this.Window.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Window != null)
            {
                if (this.Window.WindowState == FormWindowState.Normal)
                {
                    this.roundedButton2.Text = "";
                    this.Window.WindowState = FormWindowState.Maximized;
                }
                else if (this.Window.WindowState == FormWindowState.Maximized)
                {
                    this.roundedButton2.Text = "";
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
            if (this.Window != null && this.MoveOption == true)
            {
                if (this.mouseDown == true)
                {
                    this.Window.Location = new Point(
                    (this.Window.Location.X - this.lastLocation.X) + e.X, (this.Window.Location.Y - this.lastLocation.Y) + e.Y);

                    this.Update();
                }
            }

        }

        private void WindowToolbar_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.Window != null)
            {
                this.mouseDown = true;
                this.lastLocation = e.Location;
            }

        }

        private void WindowToolbar_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.Window != null)
                this.mouseDown = false;
        }
    }
}
