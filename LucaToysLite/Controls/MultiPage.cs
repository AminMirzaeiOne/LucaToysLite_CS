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
    public partial class MultiPage : UserControl
    {
        private List<Panel> pages = new List<Panel>();
        private int selectedIndex = -1;

        public event EventHandler PageChanged;

        public int SelectedIndex
        {
            get { return selectedIndex; }
            set
            {
                if (value >= 0 && value < pages.Count)
                {
                    selectedIndex = value;
                    ShowPage(selectedIndex);
                    OnPageChanged();
                }
            }
        }

        public MultiPage()
        {
            InitializeComponent();
        }

        public void AddPage(Panel page)
        {
            pages.Add(page);
            Controls.Add(page);
        }

        public void ShowPage(int index)
        {
            if (index >= 0 && index < pages.Count)
            {
                pages[index].BringToFront();
            }
        }

        private void OnPageChanged()
        {
            PageChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
