using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToysLite.Menus
{
    public partial class Widgets : UserControl
    {
        public Widgets()
        {
            InitializeComponent();
        }

        private LucaToysLite.Widgets.Clock clock = new LucaToysLite.Widgets.Clock();

        public System.Windows.Forms.Form Window { get; set; } = null;

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            if(this.Window != null)
            {
                this.Window.Controls.Add(this.clock);
            }
        }
    }
}
