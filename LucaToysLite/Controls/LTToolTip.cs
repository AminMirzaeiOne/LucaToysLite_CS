using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToysLite.Controls
{
    public enum Themes
    {
        None, Light, Dark
    }

    public class LTToolTip : System.Windows.Forms.ToolTip
    {
        public LTToolTip()
        {
            this.OwnerDraw = true;

            this.Popup += new PopupEventHandler(this.OnPopup);
            this.Draw += new DrawToolTipEventHandler(this.OnDraw);
        }

        private System.Drawing.Color foreColor = Color.White;
        private System.Drawing.Color backColor = Color.FromArgb(10, 10, 10);
        private LucaToysLite.Controls.Themes theme = Themes.Dark;

        public System.Byte BorderRadius { get; set; } = 14;
        public System.Byte BorderSize { get; set; } = 2;
        public System.Drawing.Color BorderColor { get; set; } = Color.Crimson;
        public LucaToysLite.Controls.Themes Themes
        {
            get { return this.theme; }
            set
            {
                this.theme = value;
                if (value == LucaToysLite.Controls.Themes.Dark)
                {
                    this.backColor = Color.FromArgb(10, 10, 10);
                    this.foreColor = Color.White;
                }
                else if(value == LucaToysLite.Controls.Themes.Light)
                {
                    this.backColor = Color.White;
                    this.foreColor = Color.Black;
                }
            }
        }

        private void OnPopup(object sender, PopupEventArgs e)
        {
            e.ToolTipSize = new Size(150, 50);
        }

        private void OnDraw(object sender, DrawToolTipEventArgs e)
        {
            e.Graphics.FillRoundedRectangle(new SolidBrush(this.backColor), new Rectangle(0, 0, 150, 50), this.BorderRadius);
            e.Graphics.DrawRoundedRectangle(new Pen(this.BorderColor, this.BorderSize), new Rectangle(0, 0, 150, 50), this.BorderRadius);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(e.ToolTipText, new Font("Segoe UI Semibold", 9, FontStyle.Regular), new SolidBrush(this.foreColor), e.Bounds, sf);
        }

    }
}
