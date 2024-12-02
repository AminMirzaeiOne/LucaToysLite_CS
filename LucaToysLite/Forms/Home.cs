using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using LucaToysLite.ClassLibrary;
using LucaToysLite.Controls;
using LucaToysLite.Messages;

namespace LucaToysLite.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LTUpdateMessage.Show(this, "Messi", "Ronaldo", "Hello I Am Amin Mirzaei");
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            this.timerHide.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.roundedButton1.Top < 900)
                this.roundedButton1.Top += 10;
            else
            {
                this.timerHide.Stop();
                this.timerShow.Start();
            }
        }

        private void timerShow_Tick(object sender, EventArgs e)
        {
            if (this.homeBottomMenu1.Top > 675)
                this.homeBottomMenu1.Top -= 10;
            else
            {
                this.timerShow.Stop();
            }
        }
    }
}
