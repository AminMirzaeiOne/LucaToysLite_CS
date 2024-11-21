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

namespace LucaToysLite.Menus
{
    public partial class HomeMenu : UserControl
    {
        public HomeMenu()
        {
            InitializeComponent();
            this.panel1.Controls.Add(this.users);
            this.panel1.Controls.Add(this.products);
            this.panel1.Controls.Add(this.finance);
            this.panel1.Controls.Add(this.accounting);
            this.panel1.Controls.Add(this.invoice);
            this.panel1.Controls.Add(this.documents);
            this.panel1.Controls.Add(this.exportData);
            this.panel1.Controls.Add(this.appTools);
            this.panel1.Controls.Add(this.settings);
            this.panel1.Controls.Add(this.help);


            this.users.Dock = DockStyle.Fill;
            this.products.Dock = DockStyle.Fill;
            this.finance.Dock = DockStyle.Fill;
            this.accounting.Dock = DockStyle.Fill;
            this.invoice.Dock = DockStyle.Fill;
            this.documents.Dock = DockStyle.Fill;
            this.exportData.Dock = DockStyle.Fill;
            this.appTools.Dock = DockStyle.Fill;
            this.settings.Dock = DockStyle.Fill;
            this.help.Dock = DockStyle.Fill;

            this.users.Visible = true;
            this.products.Visible = false;
            this.finance.Visible = false;
            this.accounting.Visible = false;
            this.invoice.Visible = false;
            this.documents.Visible = false;
            this.exportData.Visible = false;
            this.appTools.Visible = false;
            this.settings.Visible = false;
            this.help.Visible = false;
        }

        private LucaToysLite.Menus.Users users = new Users();
        private LucaToysLite.Menus.Products products = new Products();
        private LucaToysLite.Menus.Finance finance = new Finance();
        private LucaToysLite.Menus.Accounting accounting = new Accounting();
        private LucaToysLite.Menus.Invoice invoice = new Invoice();
        private LucaToysLite.Menus.Documents documents = new Documents();
        private LucaToysLite.Menus.ExportData exportData = new ExportData();
        private LucaToysLite.Menus.AppTools appTools = new AppTools();
        private LucaToysLite.Menus.Settings settings = new Settings();
        private LucaToysLite.Menus.Help help = new Help();

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
                    e.Graphics.DrawPath(pen, GraphPath);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton1.Checked)
            {
                this.products.Visible = false;
                this.finance.Visible = false;
                this.accounting.Visible = false;
                this.invoice.Visible = false;
                this.documents.Visible = false;
                this.exportData.Visible = false;
                this.appTools.Visible = false;
                this.animator1.Show(this.users);
            }
        }

        private void roundedRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton2.Checked)
            {
                this.users.Visible = false;
                this.finance.Visible = false;
                this.accounting.Visible = false;
                this.invoice.Visible = false;
                this.documents.Visible = false;
                this.exportData.Visible = false;
                this.appTools.Visible = false;
                this.animator1.Show(this.products);
            }
        }

        private void roundedRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton3.Checked)
            {
                this.users.Visible = false;
                this.products.Visible = false;
                this.accounting.Visible = false;
                this.invoice.Visible = false;
                this.documents.Visible = false;
                this.exportData.Visible = false;
                this.appTools.Visible = false;
                this.animator1.Show(this.finance);
            }
        }

        private void roundedRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton4.Checked)
            {
                this.users.Visible = false;
                this.products.Visible = false;
                this.finance.Visible = false;
                this.invoice.Visible = false;
                this.documents.Visible = false;
                this.exportData.Visible = false;
                this.appTools.Visible = false;
                this.animator1.Show(this.accounting);
            }
        }

        private void roundedRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton5.Checked)
            {
                this.users.Visible = false;
                this.products.Visible = false;
                this.finance.Visible = false;
                this.accounting.Visible = false;
                this.documents.Visible = false;
                this.exportData.Visible = false;
                this.appTools.Visible = false;
                this.animator1.Show(this.invoice);
            }
        }

        private void roundedRadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton6.Checked)
            {
                this.users.Visible = false;
                this.products.Visible = false;
                this.finance.Visible = false;
                this.accounting.Visible = false;
                this.invoice.Visible = false;
                this.exportData.Visible = false;
                this.appTools.Visible = false;
                this.animator1.Show(this.documents);
            }
        }

        private void roundedRadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton7.Checked)
            {
                this.users.Visible = false;
                this.products.Visible = false;
                this.finance.Visible = false;
                this.accounting.Visible = false;
                this.invoice.Visible = false;
                this.documents.Visible = false;
                this.appTools.Visible = false;
                this.animator1.Show(this.exportData);
            }
        }

        private void roundedRadioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton10.Checked)
            {
                this.users.Visible = false;
                this.products.Visible = false;
                this.finance.Visible = false;
                this.accounting.Visible = false;
                this.invoice.Visible = false;
                this.documents.Visible = false;
                this.exportData.Visible = false;
                this.animator1.Show(this.appTools);
            }
        }

        private void roundedRadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton8.Checked)
            {
                this.users.Visible = false;
                this.products.Visible = false;
                this.finance.Visible = false;
                this.accounting.Visible = false;
                this.invoice.Visible = false;
                this.documents.Visible = false;
                this.appTools.Visible = false;
                this.animator1.Show(this.settings);
            }
        }

        private void roundedRadioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (this.roundedRadioButton9.Checked)
            {
                this.users.Visible = false;
                this.products.Visible = false;
                this.finance.Visible = false;
                this.accounting.Visible = false;
                this.invoice.Visible = false;
                this.documents.Visible = false;
                this.appTools.Visible = false;
                this.settings.Visible = false;
                this.animator1.Show(this.help);
            }
        }
    }
}
