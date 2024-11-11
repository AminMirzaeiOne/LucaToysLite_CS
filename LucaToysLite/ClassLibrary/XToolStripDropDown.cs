using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToysLite.ClassLibrary
{
    public class XToolStripDropDown : ToolStripDropDown
    {
        private Control m_popedContainer;

        private ToolStripControlHost m_host;

        private bool m_fade = true;

        private const int frames = 5;

        private const int totalduration = 100;

        private const int frameduration = 20;

        public XToolStripDropDown(Control popedControl)
        {
            XToolStripDropDown xToolStripDropDown = this;
            if (popedControl == null)
            {
                throw new ArgumentNullException("content");
            }

            m_popedContainer = popedControl;
            m_fade = SystemInformation.IsMenuAnimationEnabled && SystemInformation.IsMenuFadeEnabled;
            m_host = new ToolStripControlHost(popedControl);
            m_host.AutoSize = false;
            base.Padding = (base.Margin = (m_host.Padding = (m_host.Margin = Padding.Empty)));
            popedControl.Location = Point.Empty;
            Items.Add(m_host);
            popedControl.Disposed += delegate
            {
                popedControl = null;
                xToolStripDropDown.Dispose(disposing: true);
            };
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if ((keyData & Keys.Alt) == Keys.Alt)
            {
                return false;
            }

            return base.ProcessDialogKey(keyData);
        }

        public void Show(Control control)
        {
            if (control == null)
            {
                throw new ArgumentNullException("control");
            }

            Show(control, control.ClientRectangle);
        }

        public void Show(UserControl control)
        {
            if (control == null)
            {
                throw new ArgumentNullException("control");
            }

            Show(control, control.ClientRectangle);
        }

        public void Show(Form f, Point p)
        {
            Show(f, new Rectangle(p, new Size(0, 0)));
        }

        private void Show(Control control, Rectangle area)
        {
            if (control == null)
            {
                throw new ArgumentNullException("control");
            }

            Point p = control.PointToScreen(new Point(area.Left, area.Top + area.Height));
            Rectangle workingArea = Screen.FromControl(control).WorkingArea;
            if (p.X + base.Size.Width > workingArea.Left + workingArea.Width)
            {
                p.X = workingArea.Left + workingArea.Width - base.Size.Width;
            }

            if (p.Y + base.Size.Height > workingArea.Top + workingArea.Height)
            {
                p.Y -= base.Size.Height + area.Height;
            }

            p = control.PointToClient(p);
            Show(control, p, ToolStripDropDownDirection.BelowRight);
        }

        protected override void SetVisibleCore(bool visible)
        {
            double opacity = base.Opacity;
            if (visible && m_fade)
            {
                base.Opacity = 0.0;
            }

            base.SetVisibleCore(visible);
            if (!visible || !m_fade)
            {
                return;
            }

            for (int i = 1; i <= 5; i++)
            {
                if (i > 1)
                {
                    Thread.Sleep(20);
                }

                base.Opacity = opacity * (double)i / 5.0;
            }

            base.Opacity = opacity;
        }

        protected override void OnOpening(CancelEventArgs e)
        {
            if (m_popedContainer.IsDisposed || m_popedContainer.Disposing)
            {
                e.Cancel = true;
            }
            else
            {
                base.OnOpening(e);
            }
        }

        protected override void OnOpened(EventArgs e)
        {
            m_popedContainer.Focus();
            base.OnOpened(e);
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

        private Color borderColor = Color.Crimson;
        public Color BorderColor
        {
            get { return this.borderColor; }
            set
            {
                this.borderColor = value;
                this.RecreateRegion();
            }
        }

        private byte borderSize = 2;
        public byte BorderSize
        {
            get { return this.borderSize; }
            set
            {
                this.borderSize = value;
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
                using (Pen pen = new Pen(Color.Crimson, 2))
                {
                    pen.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, GraphPath);
                }
            }
        }




    }
}
