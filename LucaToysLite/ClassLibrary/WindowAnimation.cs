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
            this.timerStart.Interval = 30;
            this.timerClose.Interval = 30;
            this.timerMaximze.Interval = 30;
            this.timerMaximze2.Interval = 30;

            this.timerStart.Tick += new EventHandler(this.TimerStart_Tick);
            this.timerClose.Tick += new EventHandler(this.TimerClose_Tick);
            this.timerMaximze.Tick += new EventHandler(this.TimerMaximize_Tick);
            this.timerMaximze2.Tick += new EventHandler(this.TimerMaximize2_Tick);
        }

        private System.Windows.Forms.Timer timerStart = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer timerClose = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer timerMaximze = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer timerMaximze2 = new System.Windows.Forms.Timer();

        private System.Windows.Forms.Form window;
        private System.Boolean isMaximize = false;

        public void Start()
        {
            this.window.Opacity = 0;
            this.timerStart.Start();
        }

        public void Close()
        {
            this.timerStart.Stop();
            this.window.Opacity = 1;
            this.timerClose.Start();
        }

        public void Maximize()
        {
            this.timerMaximze.Start();
        }

        private void TimerStart_Tick(object sender, EventArgs e)
        {
            if (this.window.Opacity < 1)
            {
                this.window.Opacity += 0.1;
            }
            else
            {
                this.timerStart.Stop();
            }
        }

        private void TimerClose_Tick(object sender, EventArgs e)
        {
            if (this.window.Opacity > 0)
            {
                this.window.Opacity -= 0.1;
            }
            else
            {
                this.timerClose.Stop();
                this.window.Close();
            }
        }

        private void TimerMaximize_Tick(object sender, EventArgs e)
        {

            if (this.window.Opacity > 0)
            {
                this.window.Opacity -= 0.1;
            }
            else
            {
                this.window.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                this.timerMaximze.Stop();
                this.timerMaximze2.Start();
            }
            

        }

        private void TimerMaximize2_Tick(object sender, EventArgs e)
        {

            if (this.window.Opacity < 1)
            {
                this.window.Opacity += 0.1;
            }
            else
            {
                this.timerMaximze2.Stop();
            }

        }


    }
}
