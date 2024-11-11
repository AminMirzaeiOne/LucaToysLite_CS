using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LucaToysLite.Controls
{
    public class LTTextBox : System.Windows.Forms.TextBox
    {
        public LTTextBox()
        {
            this.BorderStyle = BorderStyle.None;
            this.Controls.Add(this.holderLabel);
            this.Controls.Add(this.btnClear);
            this.holderLabel.Left = this.Left + 5;
            this.holderLabel.Top = this.Bottom - 10;
            this.holderLabel.BackColor = Color.FromArgb(10, 10, 10);
            this.holderLabel.ForeColor = Color.White;
            this.holderLabel.Text = "Enter Text";
            this.btnClear.FlatStyle = FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.BorderSize = 0;
            this.btnClear.EnableBorder = false;
            this.btnClear.BackColor = Color.Crimson;
            this.btnClear.ForeColor = Color.White;
            this.btnClear.Text = "";
            this.btnClear.BorderRadius = 5;
            this.btnClear.Cursor = Cursors.Arrow;
            this.btnClear.Font = new Font("Segoe MDL2 Assets", 7, FontStyle.Regular);
            this.btnClear.Click += new EventHandler(this.ClearButton_Click);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.microsoftToolStripMenuItem,
            this.toolStripSeparator1});
            this.ContextMenuStrip = this.contextMenu;
        }

        private LucaToysLite.Controls.RoundedButton btnClear = new RoundedButton();
        private System.Windows.Forms.Label holderLabel = new Label();
        private LTContextMenu contextMenu = new LTContextMenu();
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1 = new ToolStripSeparator();
        private System.Windows.Forms.ToolStripMenuItem microsoftToolStripMenuItem = new ToolStripMenuItem();


        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.Text = string.Empty;
            this.Focus();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (this.Text.Length > 0)
            {
                this.holderLabel.Visible = false;
                this.btnClear.Visible = true;
            }
            else
            {
                this.holderLabel.Visible = true;
                this.btnClear.Visible = false;
            }
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.HolderColor = Color.IndianRed;
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.HolderColor = Color.Gray;
        }


        public System.Drawing.Size ClearSize { get { return this.btnClear.Size; } set { this.btnClear.Size = value; } }
        public System.Drawing.Point ClearLocation { get { return this.btnClear.Location; } set { this.btnClear.Location = value; } }

        public System.String HolderText { get { return this.holderLabel.Text; } set { this.holderLabel.Text = value; } }
        public System.Drawing.Font HolderFont { get { return this.holderLabel.Font; } set { this.holderLabel.Font = value; } }
        public System.Drawing.Color HolderColor { get { return this.holderLabel.ForeColor; } set { this.holderLabel.ForeColor = value; } }

        public System.Drawing.Point HolderLocation { get { return this.holderLabel.Location; } set { this.holderLabel.Location = value; } }

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
            Pen penBorder = new Pen(Color.Red, 4);
            Rectangle rectBorder = new Rectangle(e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
            e.Graphics.DrawRectangle(penBorder, rectBorder);

            Rectangle textRec = new Rectangle(e.ClipRectangle.X + 1, e.ClipRectangle.Y + 1, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
            TextRenderer.DrawText(e.Graphics, Text, this.Font, textRec, this.ForeColor, this.BackColor, TextFormatFlags.Default);
        }




        //[DllImport("user32")]
        //private static extern IntPtr GetWindowDC(IntPtr hwnd);
        //private const int WM_NCPAINT = 0x85;

        //protected override void WndProc(ref Message m)
        //{
        //    base.WndProc(ref m);
        //    var dc = GetWindowDC(Handle);
        //    using (Graphics g = Graphics.FromHdc(dc))

        //    {
        //        // ایجاد یک مسیر برای رسم شکل
        //        using (GraphicsPath path = new GraphicsPath())
        //        {
        //            // تنظیم شعاع گوشه‌های گرد
        //            int radius = 10;

        //            // اضافه کردن قوس‌ها برای هر گوشه
        //            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90); // گوشه بالا سمت چپ
        //            path.AddLine(radius, 0, Width - radius, 0); // خط افقی بالا
        //            path.AddArc(new Rectangle(Width - radius, 0, radius, radius), 270, 90); // گوشه بالا سمت راست
        //            path.AddLine(Width, radius, Width, Height - radius); // خط عمودی راست
        //            path.AddArc(new Rectangle(Width - radius, Height - radius, radius, radius), 0, 90); // گوشه پایین سمت راست
        //            path.AddLine(radius, Height, 0, Height); // خط افقی پایین
        //            path.AddArc(new Rectangle(0, Height - radius, radius, radius), 90, 90); // گوشه پایین سمت چپ
        //            path.CloseFigure();

        //            // پر کردن داخل شکل با رنگ پس‌زمینه کنترل
        //            using (SolidBrush brush = new SolidBrush(BackColor))
        //            {
        //                g.FillPath(brush, path);
        //            }

        //            // رسم خط دور شکل با رنگ قرمز
        //            using (Pen pen = new Pen(Color.Crimson, 2))
        //            {
        //                g.DrawPath(pen, path);
        //            }
        //        }
        //    }

        //}


    }
}
