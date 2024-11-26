using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Setup.Forms
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            Setup.ClassLibrary.WindowAnimation animation = new ClassLibrary.WindowAnimation(this);
            animation.Start();
        }
    }
}
