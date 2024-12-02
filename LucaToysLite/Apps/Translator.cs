using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucaToysLite.Apps
{
    public partial class Translator : Form
    {
        public Translator()
        {
            InitializeComponent();
        }

        private string url = "https://translate.google.com/translate_a/single?client=at&dt=t&dt=ld&dt=qca&dt=rm&dt=bd&dj=1&hl=es-ES&ie=UTF-8&oe=UTF-8&inputm=2&otf=2&iid=1dd3b944-fa62-4b55-b330-74909a99969e";
        private string userAgent = "AndroidTranslate/5.3.0.RC02.130475354-53000263 5.1 phone TRANSLATE_OPM5_TEST_1";

        private string Senddata(string url, Dictionary<string, string> data)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.UserAgent.ParseAdd(userAgent);
            var Content = new FormUrlEncodedContent(data);
            var Respone = client.PostAsync(url, Content).Result;
            return Respone.Content.ReadAsStringAsync().Result;
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = string.Empty;
        }

        private void roundedButton9_Click(object sender, EventArgs e)
        {
            this.richTextBox2.Text = string.Empty;
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Undo();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Redo();
        }

        private void roundedButton6_Click(object sender, EventArgs e)
        {
            this.richTextBox2.Undo();
        }

        private void roundedButton8_Click(object sender, EventArgs e)
        {
            this.richTextBox2.Redo();
        }

        private void roundedButton10_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.richTextBox2.Text);
        }

        private void roundedButton7_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.richTextBox1.Text);

        }

        private void roundedButton12_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.richTextBox2.Text);

        }

        private void roundedButton13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?client=firefox-b-d&q="+this.richTextBox2.Text);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private System.String result = string.Empty;
        class MyJsonText
        {
            public int id;
            public string name;
        }

        private void roundedButton15_Click(object sender, EventArgs e)
        {
            string data = Senddata(url, new Dictionary<string, string>
            {
                {"sl" , "fa"},
                {"tl" , "en"},
                {"q" , this.richTextBox1.Text}
            });
            this.result = data.ToString();

            this.richTextBox2.Text = this.result;

        }
    }
}
