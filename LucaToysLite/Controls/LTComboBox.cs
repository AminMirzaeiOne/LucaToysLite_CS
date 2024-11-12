using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToysLite.Controls
{
    public class LTComboBox : LucaToysLite.Controls.RoundedButton
    {
        public LTComboBox()
        {
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.BorderColor = Color.Crimson;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Far;
            sf.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString("", new Font("Segoe MDL2 Assets", 9, FontStyle.Bold), new SolidBrush(Color.Crimson), new Rectangle(0,0,e.ClipRectangle.Width-10,e.ClipRectangle.Height), sf);

        }
    }
}
