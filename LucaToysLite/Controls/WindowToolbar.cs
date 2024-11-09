using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
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
            this.Load += new EventHandler(this.LoadEvent);


        }
        public System.Boolean MaximizeButton { get { return this.roundedButton2.Visible; } set { this.roundedButton2.Visible = value; } }
        public System.Boolean MinimizeButton { get { return this.roundedButton3.Visible; } set { this.roundedButton3.Visible = value; } }
        public System.Boolean MoveOption { get; set; } = true;
        public System.Boolean IconButton { get { return this.roundedButton4.Visible; } set { this.roundedButton4.Visible = value; } }
        public System.Boolean BorderStyleRadius { get; set; } = true;
        public System.Byte WindowBorderSize { get; set; } = 3;

        public System.Boolean DarkTheme { get; set; } = true;
        public System.Drawing.Color ColorPalette
        {
            get { return this.BackColor; }
            set
            {
                this.BackColor = value;
                this.roundedButton1.BackColor = value;
                this.roundedButton2.BackColor = value;
                this.roundedButton3.BackColor = value;
                this.roundedButton4.BackColor = value;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Parent != null)
                ((Form)this.Parent).Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                if (((Form)this.Parent).WindowState == FormWindowState.Normal)
                {
                    this.roundedButton2.Text = "";
                    ((Form)this.Parent).WindowState = FormWindowState.Maximized;
                }
                else if (((Form)this.Parent).WindowState == FormWindowState.Maximized)
                {
                    this.roundedButton2.Text = "";
                    ((Form)this.Parent).WindowState = FormWindowState.Normal;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.Parent != null)
                ((Form)this.Parent).WindowState = FormWindowState.Minimized;
        }

        private void WindowToolbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.Parent != null && this.MoveOption == true)
            {
                if (this.mouseDown == true)
                {
                    ((Form)this.Parent).Location = new Point(
                    (((Form)this.Parent).Location.X - this.lastLocation.X) + e.X, (this.Parent.Location.Y - this.lastLocation.Y) + e.Y);

                    this.Update();
                }
            }

        }

        private void WindowToolbar_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.Parent != null)
            {
                this.mouseDown = true;
                this.lastLocation = e.Location;
            }

        }

        private void WindowToolbar_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.Parent != null)
                this.mouseDown = false;
        }

        private int radius = 20;
        [DefaultValue(20)]
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                this.RecreateRegion();
            }
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private GraphicsPath GetRoundRectagle(Rectangle bounds, int radius)
        {
            float r = radius;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(bounds.Left, bounds.Top, r, r, 180, 90);
            path.AddArc(bounds.Right - r, bounds.Top, r, r, 270, 90);
            path.AddArc(bounds.Right - r, bounds.Bottom - r, r, r, 0, 90);
            path.AddArc(bounds.Left, bounds.Bottom - r, r, r, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void RecreateRegion()
        {
            if (this.Parent != null)
            {
                var bounds = this.Parent.ClientRectangle;
                this.Parent.Region = Region.FromHrgn(CreateRoundRectRgn(bounds.Left, bounds.Top,
                    bounds.Right, bounds.Bottom, Radius, radius));
                this.Parent.Invalidate();
            }

        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.RecreateRegion();
        }

        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();

            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius,
                             Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
            GraphPath.CloseFigure();
            return GraphPath;
        }

        private void Parent_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            RectangleF Rect = new RectangleF(0, 0, this.Parent.Width, this.Parent.Height);
            using (GraphicsPath GraphPath = GetRoundPath(Rect, this.Radius))
            {
                this.Parent.Region = new Region(GraphPath);
                using (Pen pen = new Pen(this.ColorPalette, this.WindowBorderSize))
                {
                    pen.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, GraphPath);
                }
            }
        }

        private void LoadEvent(object sender, EventArgs e)
        {
            if (this.Parent != null && this.BorderStyleRadius)
            {
                this.Parent.Paint += new PaintEventHandler(this.Parent_Paint);
                foreach (Control items in this.Parent.Controls)
                {
                    items.BackColor = this.ColorPalette;
                }
            }
        }

    }
}
