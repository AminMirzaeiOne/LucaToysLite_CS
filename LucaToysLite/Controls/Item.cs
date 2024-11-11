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
    public partial class Item : UserControl
    {
        public Item()
        {
            InitializeComponent();
            this.roundedPanel.Size = new System.Drawing.Size(200, 500);
            this.roundedPanel.BackColor = Color.FromArgb(35, 35, 35);
            this.dropDown = new LucaToysLite.ClassLibrary.XToolStripDropDown(this.roundedPanel);
            this.dropDown.AllowTransparency = true;
            this.dropDown.Width = 200;
            this.dropDown.BackColor = Color.FromArgb(35,35,35);
            this.roundedPanel.Controls.Add(tablepanel);
            this.tablepanel.Dock = DockStyle.Fill;
            this.tablepanel.BackColor = Color.Transparent;
            tablepanel.ColumnCount = 1;
            tablepanel.RowCount = 1;
        }

        public event EventHandler ClickedAction;

        TableLayoutPanel tablepanel = new TableLayoutPanel();

        private LucaToysLite.Controls.RoundedPanel roundedPanel = new RoundedPanel();
        private LucaToysLite.ClassLibrary.XToolStripDropDown dropDown;
        public List<RoundedButton> RoundedButtons = new List<RoundedButton>();

        public event EventHandler<EventArgs> SelectedItemChanged;

        private List<string> _items = new List<string>();
        public string[] Items
        {
            get { return _items.ToArray(); }
            set
            {
                _items = value.ToList();
                OnItemsChanged();
            }
        }
        int size = 0;
        private void OnItemsChanged()
        {
            this.tablepanel.Controls.Clear();
            if (this.RoundedButtons != null)
            {
                this.RoundedButtons.Clear();
            }

            TableLayoutControlCollection controls = tablepanel.Controls;

            foreach (string item in Items)
            {
                RoundedButton rb = new RoundedButton();
                this.tablepanel.RowCount++;
                rb.Text = item;
                rb.AutoSize = false;
                rb.FlatStyle = FlatStyle.Flat;
                rb.Dock = DockStyle.Fill;
                rb.Margin = new Padding(10, 3, 10, 3);
                rb.FlatAppearance.MouseOverBackColor = Color.Crimson;
                rb.FlatAppearance.MouseDownBackColor = Color.IndianRed;
                rb.FlatAppearance.BorderSize = 0;
                rb.BackColor = Color.FromArgb(20,20,20);
                rb.FlatAppearance.CheckedBackColor = Color.Plum;
                rb.ForeColor = Color.White;
                rb.Height = 70;       
                this.RoundedButtons.Add(rb);
                controls.Add(rb);
                rb.BringToFront();
                size += rb.Height;
            }

            this.roundedPanel.Height = size;
        }

        private void Rb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                SelectedItemChanged?.Invoke(rb, EventArgs.Empty);
                //this.Content = rb.Text;
            }
        }



        public System.String TitleText
        {
            get { return this.roundedButton1.Text; }
            set { this.roundedButton1.Text = value; }
        }

        public System.Boolean DarkTheme { get; set; } = true;
        public System.Drawing.Color ColorPalette
        {
            get { return this.roundedButton1.FlatAppearance.BorderColor; }
            set
            {
                this.roundedButton1.FlatAppearance.BorderColor = value;
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

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            if (this.ClickedAction != null)
                this.ClickedAction(null, null);
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            this.roundedPanel.Width = this.Width;
            this.roundedPanel.Height = this.tablepanel.Height;
            this.dropDown.Show(this,new Point(0,this.roundedButton2.Bottom+30));
        }

        private void NewSubItem()
        {

        }
    }
}
