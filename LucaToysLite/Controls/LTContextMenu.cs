using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToysLite.Controls
{
    public class LTContextMenu : ContextMenuStrip
    {
        public LTContextMenu()
        {
            this.Renderer = new MyMenuRenderer();
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

        public System.Byte BorderSize { get; set; } = 2;
        public System.Drawing.Color ColorPallet { get; set; } = Color.Crimson;

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

        public class MyMenuRenderer : ToolStripRenderer
        {
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                base.OnRenderMenuItemBackground(e);

                if (e.Item.Enabled)
                {
                    if (e.Item.IsOnDropDown == false && e.Item.Selected)
                    {
                        var rect = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 1);
                        var rect2 = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 1);
                        e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(60, 60, 60)), rect);
                        e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)), rect2);
                        e.Item.ForeColor = Color.White;
                    }
                    else
                    {
                        e.Item.ForeColor = Color.White;
                    }

                    if (e.Item.IsOnDropDown && e.Item.Selected)
                    {
                        var rect = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 1);
                        e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(60, 60, 60)), rect);
                        e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)), rect);
                        e.Item.ForeColor = Color.White;
                    }
                    if ((e.Item as ToolStripMenuItem).DropDown.Visible && e.Item.IsOnDropDown == false)
                    {
                        var rect = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 1);
                        var rect2 = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 1);
                        e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(20, 20, 20)), rect);
                        e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)), rect2);
                        e.Item.ForeColor = Color.White;
                    }
                }
            }
            protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
            {
                base.OnRenderSeparator(e);
                var DarkLine = new SolidBrush(Color.FromArgb(30, 30, 30));
                var rect = new Rectangle(30, 3, e.Item.Width - 30, 1);
                e.Graphics.FillRectangle(DarkLine, rect);
            }


            protected override void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e)
            {
                base.OnRenderItemCheck(e);

                if (e.Item.Selected)
                {
                    var rect = new Rectangle(4, 2, 18, 18);
                    var rect2 = new Rectangle(5, 3, 16, 16);
                    SolidBrush b = new SolidBrush(Color.Black);
                    SolidBrush b2 = new SolidBrush(Color.FromArgb(220, 220, 220));

                    e.Graphics.FillRectangle(b, rect);
                    e.Graphics.FillRectangle(b2, rect2);
                    e.Graphics.DrawImage(e.Image, new Point(5, 3));
                }
                else
                {
                    var rect = new Rectangle(4, 2, 18, 18);
                    var rect2 = new Rectangle(5, 3, 16, 16);
                    SolidBrush b = new SolidBrush(Color.White);
                    SolidBrush b2 = new SolidBrush(Color.FromArgb(255, 80, 90, 90));

                    e.Graphics.FillRectangle(b, rect);
                    e.Graphics.FillRectangle(b2, rect2);
                    e.Graphics.DrawImage(e.Image, new Point(5, 3));
                }
            }

            protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
            {
                base.OnRenderImageMargin(e);

                var rect = new Rectangle(0, 0, e.ToolStrip.Width, e.ToolStrip.Height);
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(20, 20, 20)), rect);

                var DarkLine = new SolidBrush(Color.FromArgb(20, 20, 20));
                var rect3 = new Rectangle(0, 0, 26, e.AffectedBounds.Height);
                e.Graphics.FillRectangle(DarkLine, rect3);

                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(20, 20, 20))), 28, 0, 28, e.AffectedBounds.Height);

                var rect2 = new Rectangle(0, 0, e.ToolStrip.Width - 1, e.ToolStrip.Height - 1);
                e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)), rect2);
            }
        }

    }
}
