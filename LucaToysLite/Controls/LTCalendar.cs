﻿using System;
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
    public partial class LTCalendar : UserControl
    {
        public LTCalendar()
        {
            InitializeComponent();
            this.ContextMenuStrip = this.ltContextMenu1;
        }

        private System.String arrowIcon = "";

        public bool ShowPanel
        {
            get { return this.roundedPanel1.Visible; }
            set
            {
                this.roundedPanel1.Visible = value;
            }
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

        public System.Boolean EnableBorder { get; set; } = true;

        public System.Drawing.Color BorderColor { get; set; } = Color.Crimson;
        public System.Byte BorderSize { get; set; } = 2;

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

        private void roundedButton1_Paint(object sender, PaintEventArgs e)
        {
            StringFormat arrow = new StringFormat();
            StringFormat title = new StringFormat();
            StringFormat date = new StringFormat();

            arrow.Alignment = StringAlignment.Far;
            arrow.LineAlignment = StringAlignment.Center;

            title.Alignment = StringAlignment.Near;
            title.LineAlignment = StringAlignment.Near;

            date.Alignment = StringAlignment.Near;
            date.LineAlignment = StringAlignment.Near;

            e.Graphics.DrawString(this.arrowIcon, new Font("Segoe MDL2 Assets",10,FontStyle.Bold),new SolidBrush(Color.Crimson),new Rectangle(0,2,e.ClipRectangle.Width-15,e.ClipRectangle.Height),arrow);
            e.Graphics.DrawString("Select Date", new Font("Segoe UI Semibold", 9,FontStyle.Regular),new SolidBrush(Color.Crimson), new Rectangle(60, 12, e.ClipRectangle.Width, e.ClipRectangle.Height), title);
            e.Graphics.DrawString("2024/11/4", new Font("Segoe UI Semibold", 11,FontStyle.Regular),new SolidBrush(Color.White), new Rectangle(60, 40, e.ClipRectangle.Width, e.ClipRectangle.Height), date);
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            if (this.ShowPanel)
            {
                this.animator1.Hide(this.roundedPanel1);
                this.arrowIcon = "";
            }
            else
            {
                this.animator1.Show(this.roundedPanel1);
                this.arrowIcon = "";

                
            }
        }

        private void showBorderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.EnableBorder = true;
            this.BackColor = Color.FromArgb(15, 15, 15);
            this.roundedButton1.BackColor = Color.FromArgb(20, 20, 20);
            this.roundedPanel1.BackColor = Color.FromArgb(20, 20, 20);
            this.Invalidate();
        }

        private void showBorderToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void hideBorderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.EnableBorder = false;
            this.BackColor = Color.FromArgb(20, 20,20);
            this.roundedButton1.BackColor = Color.FromArgb(15, 15, 15);
            this.roundedPanel1.BackColor = Color.FromArgb(15, 15, 15);
            this.Invalidate();
        }
    }
}
