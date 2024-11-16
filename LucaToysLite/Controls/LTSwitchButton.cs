using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            System.Drawing.Rectangle rightArc = new Rectangle(this.Width-arcSize-2, 0, arcSize, arcSize);
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            return path;
        }


    }
}
