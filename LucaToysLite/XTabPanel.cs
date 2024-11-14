using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LucaToysLite.Controls;

namespace LucaToysLite
{
    [DesignerCategory("Code")]
    [ToolboxItem(true)]
    public partial class XTabPanel : UserControl
    {
        private List<Panel> pages = new List<Panel>();
        private int selectedIndex = -1;

        public event EventHandler PageChanged;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public List<Panel> Pages
        {
            get { return pages; }
        }

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

        public XTabPanel()
        {
            InitializeComponent();
        }

        public void AddPage(Panel page)
        {
            pages.Add(page);
            Controls.Add(page);
            page.Visible = false;
        }

        public void ShowPage(int index)
        {
            if (index >= 0 && index < pages.Count)
            {
                foreach (Panel page in pages)
                {
                    page.Visible = false;
                }
                pages[index].Visible = true;
            }
        }

        private void OnPageChanged()
        {
            PageChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    [Designer(typeof(MultiPageEditor))]
    public class MultiPageEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;

        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object
     value)
        {
            XTabPanel multiPage = (XTabPanel)context.Instance;

            MultiPageEditorForm form = new MultiPageEditorForm(multiPage);
            if (form.ShowDialog() == DialogResult.OK)
            {
                return multiPage;
            }

            return base.EditValue(context, provider, value);
        }
    }

    public partial class MultiPageEditorForm : Form
    {
        private XTabPanel multiPage;
        private ListBox lbPages;

        public MultiPageEditorForm(XTabPanel multiPage)
        {
            this.multiPage = multiPage;

            lbPages.DataSource = multiPage.Pages; // صفحات را به لیست باکس اضافه می کنیم

            // اضافه کردن دکمه برای افزودن صفحه جدید
            Button btnAddPage = new Button();
            btnAddPage.Text = "افزودن صفحه جدید";
            btnAddPage.Click += btnAddPage_Click;
            Controls.Add(btnAddPage);
        }

        private void btnAddPage_Click(object sender, EventArgs e)
        {
            Panel newPage = new Panel();
            multiPage.Pages.Add(newPage);
            lbPages.DataSource = null;
            lbPages.DataSource = multiPage.Pages; // لیست باکس را دوباره پر می کنیم
        }
    }
}
