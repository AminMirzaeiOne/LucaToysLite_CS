using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucaToysLite.Controls
{
    public static class LTMessageBox
    {
        public enum IconTypes { None, Error, Warning, Information }
        public enum ActionTypes { None, Close, Restart, Exit }
        public enum StartSounds { None, GSound, DSound, CSound }

        public static void Show(string title, string caption)
        {
            using (var form = new LucaToysLite.Messages.Hybrid(title, caption))
            {
                form.ShowDialog();
            }
        }

        public static void Show(string title, string caption, string description)
        {
            using (var form = new LucaToysLite.Messages.Hybrid(title, caption, description))
            {
                form.ShowDialog();
            }
        }

        public static void Show(string title, string caption, string description, IconTypes icontype)
        {
            using (var form = new LucaToysLite.Messages.Hybrid(title, caption, description, icontype))
            {
                form.ShowDialog();
            }
        }

        public static void Show(string title, string caption, string description, System.Drawing.Image icon)
        {
            using (var form = new LucaToysLite.Messages.Hybrid(title, caption, description, icon))
            {
                form.ShowDialog();
            }
        }

        public static void Show(string title, string caption, string description, ActionTypes actiontype)
        {
            using (var form = new LucaToysLite.Messages.Hybrid(title, caption, description, actiontype))
            {
                form.ShowDialog();
            }
        }

        public static void Show(string title, string caption, string description, System.Drawing.Image icon, StartSounds sound)
        {
            using (var form = new LucaToysLite.Messages.Hybrid(title, caption, description, icon, sound))
            {
                form.ShowDialog();
            }
        }
        public static void Show(string title, string caption, string description, ActionTypes actiontype, StartSounds sound)
        {
            using (var form = new LucaToysLite.Messages.Hybrid(title, caption, description, actiontype, sound))
            {
                form.ShowDialog();
            }
        }
        public static void Show(string title, string caption, string description, IconTypes icontype, StartSounds sound)
        {
            using (var form = new LucaToysLite.Messages.Hybrid(title, caption, description, icontype, sound))
            {
                form.ShowDialog();
            }
        }
    }
}
