using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToysLite.Controls
{
    public class LTSwitchButton : System.Windows.Forms.CheckBox
    {
        private System.Drawing.Color onBackColor = Color.Crimson;
        private System.Drawing.Color onToggleColor = Color.Linen;
        private System.Drawing.Color offBackColor = Color.Gray;
        private System.Drawing.Color offToggleColor = Color.Gainsboro;
        private System.Boolean solidColor = true;

        public System.Drawing.Color OnBackColor
        {
            get { return this.onBackColor; }
            set
            {
                this.onBackColor = value;
                this.Invalidate();
            }
        }

        public System.Drawing.Color OnToggleColor
        {
            get { return this.onToggleColor; }
            set
            {
                this.onToggleColor = value;
                this.Invalidate();
            }
        }

        public System.Drawing.Color OffBackColor
        {
            get { return this.offBackColor; }
            set
            {
                this.offBackColor = value;
                this.Invalidate();
            }
        }

        public System.Drawing.Color OffToggleColor
        {
            get { return this.offToggleColor; }
            set
            {
                this.offToggleColor = value;
                this.Invalidate();
            }
        }

        public System.Boolean SolidColor
        {
            get { return this.solidColor; }
            set
            {
                this.solidColor = value;
                this.Invalidate();
            }
        }

        public LTSwitchButton()
        {
            this.MinimumSize = new Size(45, 23);
        }

        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            System.Drawing.Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            System.Drawing.Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int togglesize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);
            if (this.Checked)
            {
                if (this.SolidColor)
                    pevent.Graphics.FillPath(new SolidBrush(this.OnBackColor), this.GetFigurePath());
                else
                    pevent.Graphics.DrawPath(new Pen(this.OnBackColor, 2), this.GetFigurePath());
                pevent.Graphics.FillEllipse(new SolidBrush(this.OnToggleColor), new Rectangle(this.Width - this.Height + 1, 2, togglesize, togglesize));
            }
            else
            {
                if (this.SolidColor)
                    pevent.Graphics.FillPath(new SolidBrush(this.OffBackColor), this.GetFigurePath());
                else
                    pevent.Graphics.DrawPath(new Pen(this.OffBackColor, 2), this.GetFigurePath());
                pevent.Graphics.FillEllipse(new SolidBrush(this.OffToggleColor), new Rectangle(2, 2, togglesize, togglesize));
            }

        }


    }
}
