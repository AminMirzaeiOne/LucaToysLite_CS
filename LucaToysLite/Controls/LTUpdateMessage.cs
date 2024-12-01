using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucaToysLite.Controls
{
    public static class LTUpdateMessage
    {
        public static void Show(System.Windows.Forms.Form owner, string title, string caption)
        {

            using (var form = new LucaToysLite.Messages.Update(owner, title, caption))
            {
                form.ShowDialog();
            }
        }

        public static void Show(System.Windows.Forms.Form owner, string title, string caption, string description)
        {
            using (var form = new LucaToysLite.Messages.Update(owner, title, caption, description))
            {
                form.ShowDialog();
            }
        }
    }
}
