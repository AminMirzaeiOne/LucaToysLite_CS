using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToysLite.Controls
{
    public partial class WindowToolbar : UserControl
    {
        public WindowToolbar()
        {
            InitializeComponent();
        }

        public System.Windows.Forms.Form Window { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.Window != null) 
                this.Window.Close();
        }
    }
}
