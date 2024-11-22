using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToysLite.Controls
{
    public partial class LTVertScrollBar : UserControl
    {
        public LTVertScrollBar()
        {
            InitializeComponent();
        }

        private int radius = 20;
        private bool mouseDown;
        private Point lastLocation;

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

        public System.Byte Value { get; set; } = 0;
        public System.Int32 ScrollHeight
        {
            get { return this.roundedButton3.Size.Height; }
            set
            {
                this.roundedButton3.Height = value;
            }
        }

        public System.Windows.Forms.Panel Page { get; set; }

        public System.Boolean EnableBorder { get; set; } = true;

        public System.Drawing.Color BorderColor { get; set; } = Color.Crimson;
        public System.Byte BorderSize { get; set; } = 2;

        public System.Drawing.Color ColorPallet
        {
            get { return this.roundedButton1.BackColor; }
            set
            {
                this.roundedButton1.BackColor = value;
                this.roundedButton2.BackColor = value;
                this.roundedButton3.BackColor = value;
                this.BorderColor = value;
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
            var bounds = ClientRectangle;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(bounds.Left, bounds.Top,
                bounds.Right, bounds.Bottom, Radius, radius));
            this.Invalidate();
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

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            using (GraphicsPath GraphPath = GetRoundPath(Rect, this.Radius))
            {
                this.Region = new Region(GraphPath);
                using (Pen pen = new Pen(this.BorderColor, this.BorderSize))
                {
                    pen.Alignment = PenAlignment.Inset;
                    if (this.EnableBorder)
                        e.Graphics.DrawPath(pen, GraphPath);
                }
            }
        }

        private void roundedButton3_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseDown = true;
            this.lastLocation = e.Location;
        }

        private void roundedButton3_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseDown = false;
        }

        private void roundedButton3_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mouseDown == true)
            {
                if (this.roundedButton3.Top > this.roundedButton1.Bottom && this.roundedButton3.Bottom < this.roundedButton2.Top)
                {
                    this.roundedButton3.Location = new Point(
                    this.roundedButton3.Location.X, (this.roundedButton3.Location.Y - this.lastLocation.Y) + e.Y);
                    if (this.Page != null)
                        this.Page.AutoScrollPosition = this.roundedButton3.Location;

                    this.Update();
                }

            }
        }

        private void roundedButton2_MouseDown(object sender, MouseEventArgs e)
        {
            this.timerBottom.Start();
        }

        private void timerBottom_Tick(object sender, EventArgs e)
        {
            if (this.roundedButton3.Bottom < this.roundedButton2.Top)
            {
                this.roundedButton3.Location = new Point(this.roundedButton3.Location.X, this.roundedButton3.Location.Y + 5);

                this.Update();
            }
        }

        private void roundedButton2_MouseUp(object sender, MouseEventArgs e)
        {
            this.timerBottom.Stop();
        }

        private void timerTop_Tick(object sender, EventArgs e)
        {
            if (this.roundedButton3.Top > this.roundedButton1.Bottom)
            {
                this.roundedButton3.Location = new Point(this.roundedButton3.Location.X, this.roundedButton3.Location.Y - 5);

                this.Update();
            }
        }

        private void roundedButton1_MouseDown(object sender, MouseEventArgs e)
        {
            this.timerTop.Start();
        }

        private void roundedButton1_MouseUp(object sender, MouseEventArgs e)
        {
            this.timerTop.Stop();
        }

        private void LTVertScrollBar_DoubleClick(object sender, EventArgs e)
        {
            this.roundedButton3.Top = Cursor.Clip.Location.Y;
        }
    }

}
