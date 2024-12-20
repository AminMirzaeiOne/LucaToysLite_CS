﻿using System;
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
    public class LTGradintPanel : System.Windows.Forms.Panel
    {
        public LTGradintPanel()
        {
            this.DoubleBuffered = true;
            this.timer.Tick += (s, e) => { this.Angle = this.Angle % 360 + 1; };
            if (this.Animation)
                this.timer.Start();
            else
                this.timer.Stop();
        }

        private Color cl1 = Color.RoyalBlue, cl2 = Color.Crimson;
        private Timer timer = new Timer();
        private float ang = 45;
        private System.Boolean animation = true;

        [DefaultValue(50)]
        public System.Byte Interval
        {
            get { return (byte)this.timer.Interval; }
            set { this.timer.Interval = value; }
        }

        public System.Boolean Animation
        {
            get { return this.animation; }
            set
            {
                this.animation = value;
                if (value)
                    this.timer.Start();
                else
                    this.timer.Stop();
            }
        }

        public float Angle
        {
            get { return this.ang; }
            set { this.ang = value; this.Invalidate(); }
        }

        public System.Drawing.Color ColorOne
        {
            get { return this.cl1; }
            set
            {
                this.cl1 = value;
            }
        }

        public System.Drawing.Color ColorTwo
        {
            get { return this.cl2; }
            set
            {
                this.cl2 = value;
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

                    e.Graphics.FillPath(new LinearGradientBrush(ClientRectangle, this.ColorOne, this.ColorTwo, this.Angle), GraphPath);
                    pen.Alignment = PenAlignment.Inset;
                    if (this.EnableBorder)
                        e.Graphics.DrawPath(pen, GraphPath);
                }
            }


        }


    }
}
