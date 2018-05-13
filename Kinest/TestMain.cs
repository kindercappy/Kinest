using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Library;
using KinestOps;
using OpenQA.Selenium.PhantomJS;

namespace Kinest
{
    public partial class TestMain : Form
    {
        TestIt testUrl;
        public TestMain()
        {
            InitializeComponent();
        }

        private void TestMain_Load(object sender, EventArgs e)
        {
            //var myConnection = Common.GetConnection();
            URLOps url = new URLOps();
            List<string> urls = url.getUrlData();
            urls.Sort();
            this.cbUrl.DataSource = urls;
            this.cbProtocol.SelectedIndex = 0;
        }

        private void btnOpenUrl_Click(object sender, EventArgs e)
        {
            string url = this.cbUrl.Text;
            string protocol = this.cbProtocol.Text;
            string fullUrl = protocol + "://" + url;
            testUrl = new TestIt(fullUrl);

        }

        private void btnCloseBrowsers_Click(object sender, EventArgs e)
        {
            testUrl.closeBrowsers();
        }

        private void btnTestSqlInsert_Click(object sender, EventArgs e)
        {
            URLOps url = new URLOps(this.cbProtocol.Text, this.cbUrl.Text);
            string message = url.AddUrl();
            MessageBox.Show(message);
        }

        private void btnShowUrls_Click(object sender, EventArgs e)
        {
            URLOps url = new URLOps();
        }

        private void cbUrl_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbUrl_TextChanged(object sender, EventArgs e)
        {
            //this.cbUrl.DroppedDown = true;
        }

        private void cbUrl_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void cbUrl_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void cbUrl_Enter(object sender, EventArgs e)
        {
            URLOps url = new URLOps();
            List<string> urls = url.getUrlData();
            urls.Sort();
            this.cbUrl.DataSource = urls;
            this.cbUrl.DroppedDown = true;
        }
    }
}
