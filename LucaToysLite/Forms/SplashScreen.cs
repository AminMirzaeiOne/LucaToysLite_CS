using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace LucaToysLite.Forms
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            this.loadingControl1.StartProgress();

        }

        private void loadingControl1_EndProcess(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(200);
            LucaToysLite.Forms.Home home = new Home();
            //home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
