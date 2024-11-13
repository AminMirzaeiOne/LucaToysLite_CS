using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucaToysLite.Controls
{
    public static class LTMessageBox
    {
        public enum IconTypes { None,Error, Warning, Information }
        public enum ActionTypes { None,Close, Restart, Exit }
        public enum StartSounds { None,GSound, DSound, CSound }

        public static void Show(string title, string caption)
        {

        }

        public static void Show(string title, string caption, string description)
        {

        }

        public static void Show(string title, string caption, string description, IconTypes icontype)
        {

        }

        public static void Show(string title, string caption, string description, System.Drawing.Image icon)
        {

        }

        public static void Show(string title, string caption, string description, ActionTypes actiontype)
        {

        }

        public static void Show(string title, string caption, string description, System.Drawing.Image icon, StartSounds sound)
        {

        }
        public static void Show(string title, string caption, string description, ActionTypes actiontype, StartSounds sound)
        {

        }
        public static void Show(string title, string caption, string description, IconTypes icontype, StartSounds sound)
        {

        }
    }
}
