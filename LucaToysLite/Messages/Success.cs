using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToysLite.Messages
{
    public partial class Success : Form
    {
        public Success()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Success_Load(object sender, EventArgs e)
        {
            this.loadingControl1.StartProgress();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            this.windowToolbar1.Close();
        }
    }
}
