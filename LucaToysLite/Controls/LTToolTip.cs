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
    public class LTToolTip : System.Windows.Forms.ToolTip
    {
        public LTToolTip()
        {
            this.OwnerDraw = true;
            
            this.Popup += new PopupEventHandler(this.OnPopup);
            this.Draw += new DrawToolTipEventHandler(this.OnDraw);
        }

        private void OnPopup(object sender, PopupEventArgs e)
        {
            e.ToolTipSize = new Size(150, 50);
        }

        private void OnDraw(object sender, DrawToolTipEventArgs e)
        {
            e.Graphics.FillRoundedRectangle(new SolidBrush(Color.FromArgb(10,10,10)),new Rectangle(0,0,150,50),14);
            e.Graphics.DrawRoundedRectangle(new Pen(Color.Crimson, 3), new Rectangle(0, 0, 150, 50), 14);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(e.ToolTipText, new Font("Segoe UI Semibold", 9, FontStyle.Regular), new SolidBrush(Color.White),e.Bounds,sf);
        }

    }
}
