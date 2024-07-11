using System;
using System.Windows.Forms;

namespace AyÇiçeği_Pansiyon_Uygulaması_2
{
    public partial class FrmGazeteler : Form
    {
        public FrmGazeteler()
        {
            InitializeComponent();
        }

        private void FrmGazeteler_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true; // Script hatalarını göstermemesi için
        }

        private void NavigateToUrl(string url)
        {
            try
            {
                webBrowser1.Navigate(new Uri(url));
            }
            catch (UriFormatException)
            {
                MessageBox.Show("Geçersiz URL formatı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NavigateToUrl("http://www.hurriyet.com.tr");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NavigateToUrl("http://www.milliyet.com.tr");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NavigateToUrl("http://www.sozcu.com.tr");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NavigateToUrl("http://www.haberturk.com");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NavigateToUrl("http://www.fanatik.com.tr");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NavigateToUrl("http://www.onedio.com");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
