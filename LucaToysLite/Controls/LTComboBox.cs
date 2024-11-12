using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace LucaToysLite.Controls
{
    public class LTComboBox : LucaToysLite.Controls.RoundedButton
    {
        public LTComboBox()
        {
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.BorderColor = Color.Crimson;
            xDrop = new LucaToysLite.ClassLibrary.XToolStripDropDown(panel);
            this.panel.BackColor = Color.Black;
            this.chilePanel.BackColor = Color.Transparent;
            this.panel.Controls.Add(this.chilePanel);
            this.chilePanel.Location = new System.Drawing.Point(5, 5);
            this.chilePanel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            this.panel.BorderSize = 3;





        }

        private LucaToysLite.ClassLibrary.XToolStripDropDown xDrop;
        private LucaToysLite.Controls.RoundedPanel panel = new RoundedPanel();
        private System.Windows.Forms.Panel chilePanel = new Panel();
        private System.Int32 height = 0;
        private System.Byte itemsHeight = 40;
        private System.Drawing.Color itemsCheckedColor = Color.Plum;
        private System.Drawing.Color itemsForeColor = Color.White;
        private System.Drawing.Color itemsBackColor = Color.FromArgb(20, 20, 20);
        private System.Drawing.Font itemsFont = new Font("Segoe UI Semibold", 9, FontStyle.Regular);
        private System.Boolean imageStyle = false;
        private System.Boolean topDirection = false;
        private System.Drawing.Color colorPallet = Color.Crimson;
        public List<RadioButton> RadioItems = new List<RadioButton>();

        public System.Drawing.Color ColorPallet
        {
            get { return this.colorPallet; }
            set
            {
                this.colorPallet = value;
                this.ItemsCheckedColor = value;
            }
        }

        public System.Byte ItemsHeight
        {
            get { return this.itemsHeight; }
            set
            {
                this.itemsHeight = value;
                if (this.RadioItems != null)
                {
                    foreach (RadioButton item in this.RadioItems)
                    {
                        item.Height = value;
                    }
                }

            }
        }

        public System.Drawing.Font ItemsFont
        {
            get { return this.itemsFont; }
            set
            {
                this.itemsFont = value;
                if (this.RadioItems != null)
                {
                    foreach (RadioButton item in this.RadioItems)
                    {
                        item.Font = value;
                    }
                }

            }
        }

        public System.Drawing.Color ItemsCheckedColor
        {
            get { return this.itemsCheckedColor; }
            set
            {
                this.itemsCheckedColor = value;
                if (this.RadioItems != null)
                {
                    foreach (RadioButton item in this.RadioItems)
                    {
                        item.FlatAppearance.CheckedBackColor = value;
                    }
                }

            }
        }

        public System.Drawing.Color ItemsForeColor
        {
            get { return this.itemsForeColor; }
            set
            {
                this.itemsForeColor = value;
                if (this.RadioItems != null)
                {
                    foreach (RadioButton item in this.RadioItems)
                    {
                        item.ForeColor = value;
                    }
                }

            }
        }

        public System.Drawing.Color ItemsBackColor
        {
            get { return this.itemsBackColor; }
            set
            {
                this.itemsBackColor = value;
                if (this.RadioItems != null)
                {
                    foreach (RadioButton item in this.RadioItems)
                    {
                        item.BackColor = value;
                    }
                }

            }
        }

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

        public bool TopDirection { get; set; } = false;

        private void OnItemsChanged()
        {
            this.chilePanel.Controls.Clear();
            if (this.RadioItems != null)
            {
                this.RadioItems.Clear();
            }
            foreach (string item in Items)
            {
                RadioButton rb = new RadioButton();
                rb.Text = item;
                rb.AutoSize = false;
                rb.FlatStyle = FlatStyle.Flat;
                rb.Appearance = Appearance.Button;
                rb.Dock = DockStyle.Top;
                rb.FlatAppearance.BorderSize = 0;
                rb.FlatAppearance.CheckedBackColor = Color.Plum;
                rb.ForeColor = Color.White;
                rb.CheckedChanged += Rb_CheckedChanged;
                this.RadioItems.Add(rb);
                this.chilePanel.Controls.Add(rb);
                rb.BringToFront();
            }
        }

        private void Rb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                SelectedItemChanged?.Invoke(rb, EventArgs.Empty);
                this.Text = rb.Text;
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (this.height == 0)
            {
                foreach (RadioButton radio in this.RadioItems)
                {
                    this.height += radio.Size.Height;
                }
            }

            this.panel.Size = new Size(this.Width, height + 5);
            this.chilePanel.Size = new Size(this.panel.Size.Width - 8, this.panel.Size.Height - 9);

            if (!this.TopDirection)
                xDrop.Show(this);
            else
                xDrop.Show(this, new Point(0, 0 - this.panel.Bottom));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Far;
            sf.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString("", new Font("Segoe MDL2 Assets", 9, FontStyle.Bold), new SolidBrush(this.ColorPallet), new Rectangle(0,0,e.ClipRectangle.Width-10,e.ClipRectangle.Height+4), sf);

        }
    }
}
