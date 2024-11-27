using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToysLite.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            this.ltGradintPanel1.Animation = true;
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            LucaToysLite.Forms.LoginProblem loginProblem = new LoginProblem();
            loginProblem.Show();
        }
    }
}
