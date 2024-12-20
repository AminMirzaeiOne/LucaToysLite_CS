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
using LucaToysLite.Controls;

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
            this.panel1.Controls.Add(this.widgets);
            this.panel1.Controls.Add(this.salesman);
            this.panel1.Controls.Add(this.about);


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
            this.widgets.Dock = DockStyle.Fill;
            this.salesman.Dock = DockStyle.Fill;
            this.about.Dock = DockStyle.Fill;

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
            this.widgets.Visible = false;
            this.salesman.Visible = false;
            this.about.Visible = false;

        }

        public System.Boolean LargeSub
        {
            get { return this.panel1.Visible; }
            set
            {
                this.panel1.Visible = value;
                if (value)
                    this.Height = 230;
                else
                    this.Height = 80;
            }
        }

        private byte leftMax = 10;
        private byte righttMax = 10;

        private byte leftMin = 0;
        private byte rightMin = 0;

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
        private LucaToysLite.Menus.Widgets widgets = new Widgets();
        private LucaToysLite.Menus.Salesman salesman = new Salesman();
        private LucaToysLite.Menus.About about = new About();

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

        private void radioUsers_CheckedChanged(object sender, EventArgs e)
        {
            if (this.LargeSub)
            {
                var rb = (RadioButton)sender;
                if (rb == this.radioUsers)
                {
                    foreach (UserControl item in this.panel1.Controls)
                    {
                        if (item != this.users)
                            item.Visible = false;
                        else
                            this.animator1.Show(this.users);
                    }
                }
                else if (rb == this.radioProduct)
                {
                    foreach (UserControl item in this.panel1.Controls)
                    {
                        if (item != this.products)
                            item.Visible = false;
                        else
                            this.animator1.Show(this.products);
                    }
                }
                else if (rb == this.radioFinance)
                {
                    foreach (UserControl item in this.panel1.Controls)
                    {
                        if (item != this.finance)
                            item.Visible = false;
                        else
                            this.animator1.Show(this.finance);
                    }
                }
                else if (rb == this.radioAccounting)
                {
                    foreach (UserControl item in this.panel1.Controls)
                    {
                        if (item != this.accounting)
                            item.Visible = false;
                        else
                            this.animator1.Show(this.accounting);
                    }
                }
                else if (rb == this.radioInvoice)
                {
                    foreach (UserControl item in this.panel1.Controls)
                    {
                        if (item != this.invoice)
                            item.Visible = false;
                        else
                            this.animator1.Show(this.invoice);
                    }
                }
                else if (rb == this.radioDocuments)
                {
                    foreach (UserControl item in this.panel1.Controls)
                    {
                        if (item != this.documents)
                            item.Visible = false;
                        else
                            this.animator1.Show(this.documents);
                    }
                }
                else if (rb == this.radioExport)
                {
                    foreach (UserControl item in this.panel1.Controls)
                    {
                        if (item != this.exportData)
                            item.Visible = false;
                        else
                            this.animator1.Show(this.exportData);
                    }
                }
                else if (rb == this.radioApps)
                {
                    foreach (UserControl item in this.panel1.Controls)
                    {
                        if (item != this.appTools)
                            item.Visible = false;
                        else
                            this.animator1.Show(this.appTools);
                    }
                }
                else if (rb == this.radioWidgets)
                {
                    this.widgets.Window = (Form)this.Parent;
                    foreach (UserControl item in this.panel1.Controls)
                    {
                        if (item != this.widgets)
                            item.Visible = false;
                        else
                            this.animator1.Show(this.widgets);
                    }
                }
                else if (rb == this.radioSettings)
                {
                    foreach (UserControl item in this.panel1.Controls)
                    {
                        if (item != this.settings)
                            item.Visible = false;
                        else
                            this.animator1.Show(this.settings);
                    }
                }
                else if (rb == this.radioHelp)
                {
                    foreach (UserControl item in this.panel1.Controls)
                    {
                        if (item != this.help)
                            item.Visible = false;
                        else
                            this.animator1.Show(this.help);
                    }
                }
                else if (rb == this.radioSalesman)
                {
                    foreach (UserControl item in this.panel1.Controls)
                    {
                        if (item != this.salesman)
                            item.Visible = false;
                        else
                            this.animator1.Show(this.salesman);
                    }
                }
                else if (rb == this.radioAbout)
                {
                    foreach (UserControl item in this.panel1.Controls)
                    {
                        if (item != this.about)
                            item.Visible = false;
                        else
                            this.animator1.Show(this.about);
                    }
                }
            }
            
        }

        private void radioUsers_MouseDown(object sender, MouseEventArgs e)
        {
            this.usersContextMenu.Show(this.radioUsers, new Point(0, 70));
        }

        private void radioProduct_MouseDown(object sender, MouseEventArgs e)
        {
            this.productContextMenu.Show(this.radioProduct, new Point(0, 70));
        }

        private void radioFinance_MouseDown(object sender, MouseEventArgs e)
        {
            this.financeContextMenu.Show(this.radioFinance, new Point(0, 70));
        }

        private void radioAccounting_MouseDown(object sender, MouseEventArgs e)
        {
            this.accountingContextMenu.Show(this.radioAccounting, new Point(0, 70));
        }

        private void radioInvoice_MouseDown(object sender, MouseEventArgs e)
        {
            this.invoiceContextMenu.Show(this.radioInvoice, new Point(0, 70));
        }

        private void radioDocuments_MouseDown(object sender, MouseEventArgs e)
        {
            this.documentsContextMenu.Show(this.radioDocuments, new Point(0, 70));
        }

        private void radioSalesman_MouseDown(object sender, MouseEventArgs e)
        {
            this.salesmanContextMenu.Show(this.radioSalesman, new Point(0, 70));
        }

        private void radioExport_MouseDown(object sender, MouseEventArgs e)
        {
            this.exportContextMenu.Show(this.radioExport, new Point(0, 70));
        }

        private void radioApps_MouseDown(object sender, MouseEventArgs e)
        {
            this.appToolsContextMenu.Show(this.radioApps, new Point(0, 70));
        }

        private void radioWidgets_MouseDown(object sender, MouseEventArgs e)
        {
            this.widgetsContextMenu.Show(this.radioWidgets, new Point(0, 70));
        }

        private void radioSettings_MouseDown(object sender, MouseEventArgs e)
        {
            this.settingsContextMenu.Show(this.radioSettings, new Point(0, 70));
        }

        private void radioHelp_MouseDown(object sender, MouseEventArgs e)
        {
            this.helpContextMenu.Show(this.radioHelp, new Point(0, 70));
        }

        private void radioAbout_MouseDown(object sender, MouseEventArgs e)
        {
            this.aboutContextMenu.Show(this.radioAbout, new Point(0, 70));
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            this.timerRight.Stop();
            this.timerLeft.Start();
        }



        private void roundedButton1_Click(object sender, EventArgs e)
        {
            this.timerLeft.Stop();
            this.timerRight.Start();
        }

        private void timerLeft_Tick(object sender, EventArgs e)
        {
            if (this.leftMin < 80)
            {
                this.leftMin += 8;
                foreach (RoundedRadioButton item in this.panel2.Controls.OfType<RoundedRadioButton>())
                {
                    item.Left += this.leftMin;
                }
            }
            else
            {
                this.timerLeft.Stop();
                this.rightMin = 0;
            }

        }

        private void timerRight_Tick(object sender, EventArgs e)
        {
            if (this.rightMin < 80)
            {
                this.rightMin += 8;
                foreach (RoundedRadioButton item in this.panel2.Controls.OfType<RoundedRadioButton>())
                {
                    item.Left -= this.leftMin;
                }
            }
            else
            {
                this.timerRight.Stop();
                this.leftMin = 0;
            }
        }
    }
}
