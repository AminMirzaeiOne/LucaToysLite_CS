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
    public class MultiPage : System.Windows.Forms.TabControl
    {
        public System.Drawing.Color Background { get; set; } = Color.Black;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillRectangle(new SolidBrush(this.Background), e.ClipRectangle);
        }


        public MultiPage()
        {
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.SizeMode = TabSizeMode.Fixed;
            this.ItemSize = new Size(100, 36);
            this.SetStyle(ControlStyles.UserPaint, true);
            
        }
    }
}
