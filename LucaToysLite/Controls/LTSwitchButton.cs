using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToysLite.Controls
{
    public class LTSwitchButton : System.Windows.Forms.CheckBox
    {
        private System.Drawing.Color onBackColor = Color.Crimson;
        private System.Drawing.Color onToggleColor = Color.White;
        private System.Drawing.Color offBackColor = Color.Gray;
        private System.Drawing.Color offToggleColor = Color.Gainsboro;
        private System.Boolean solidColor = false;


        protected override void OnCheckedChanged(EventArgs e)
        {
            base.OnCheckedChanged(e);
            this.SolidColor = this.Checked;
        }

        public System.Byte Radius { get; set; } = 40;

        public System.Drawing.Color ColorPallet
        {
            get { return this.onBackColor; }
            set
            {
                this.OnBackColor = value;
                this.OffBackColor = value;
            }
        }


        public System.Drawing.Color OnBackColor
        {
            get { return this.onBackColor; }
            set
            {
                this.onBackColor = value;
                this.Invalidate();
            }
        }

        public System.Drawing.Color OnToggleColor
        {
            get { return this.onToggleColor; }
            set
            {
                this.onToggleColor = value;
                this.Invalidate();
            }
        }

        public System.Drawing.Color OffBackColor
        {
            get { return this.offBackColor; }
            set
            {
                this.offBackColor = value;
                this.Invalidate();
            }
        }

        public System.Drawing.Color OffToggleColor
        {
            get { return this.offToggleColor; }
            set
            {
                this.offToggleColor = value;
                this.Invalidate();
            }
        }

        public System.Boolean SolidColor
        {
            get { return this.solidColor; }
            set
            {
                this.solidColor = value;
                this.Invalidate();
            }
        }

        public LTSwitchButton()
        {
            //this.MinimumSize = new Size(45, 25);
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
                bounds.Right, bounds.Bottom, Radius, this.Radius));
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


        protected override void OnPaint(PaintEventArgs pevent)
        {
            

            int togglesize = this.Height - 10;
            pevent.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            pevent.Graphics.Clear(this.Parent.BackColor);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = GetRoundPath(Rect, this.Radius);
            this.Region = new Region(GraphPath);
            if (this.Checked)
            {
                if (this.SolidColor)
                {
                    pevent.Graphics.FillPath(new SolidBrush(this.OnBackColor), GraphPath);
                }
                else
                    pevent.Graphics.DrawPath(new Pen(this.OnBackColor, 4), GraphPath);
                pevent.Graphics.FillEllipse(new SolidBrush(this.OnToggleColor), new Rectangle(this.Width - this.Height + 1, 5, togglesize, togglesize));
            }
            else
            {
                if (this.SolidColor)
                    pevent.Graphics.FillPath(new SolidBrush(this.OffBackColor), GraphPath);
                else
                    pevent.Graphics.DrawPath(new Pen(this.OffBackColor, 4), GraphPath);
                pevent.Graphics.FillEllipse(new SolidBrush(this.OffToggleColor), new Rectangle(4, 5, togglesize, togglesize));
            }

        }


    }
}
