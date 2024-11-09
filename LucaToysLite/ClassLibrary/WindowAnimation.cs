using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LucaToysLite.ClassLibrary
{
    public class WindowAnimation
    {
        public WindowAnimation(System.Windows.Forms.Form frm)
        {
            this.window = frm;
            this.timerAnimation.Interval = 20;
            this.timerAnimation.Tick += new EventHandler(this.TimerAnimation_Tick);
        }

        private System.Windows.Forms.Timer timerAnimation = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Form window;

        public void Start()
        {
            this.window.Opacity = 0;
            this.timerAnimation.Start();
        }

        private void TimerAnimation_Tick(object sender, EventArgs e)
        {
            if (this.window.Opacity < 1)
            {
                this.window.Opacity += 0.1;
            }
            else
            {
                this.timerAnimation.Stop();
            }
        }

    }
}
