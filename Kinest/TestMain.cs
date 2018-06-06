using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KinestFactory;
//using Library;
using OpenQA.Selenium.PhantomJS;

namespace Kinest
{
    public partial class TestMain : Form
    {
        URLOpsFac urlOpsFac;
        private TestUrlFac testUrl;

        public TestMain()
        {
            InitializeComponent();
        }

        private void TestMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kinestDataSet.sitesStored' table. You can move, or remove it, as needed.
            //this.sitesStoredTableAdapter.Fill(this.kinestDataSet.sitesStored);
            PopulateUrlData(false);
            this.cbProtocol.SelectedIndex = 0;
        }

        private void btnOpenUrl_Click(object sender, EventArgs e)
        {
            //string url = this.cbUrl.Text;
            //string protocol = this.cbProtocol.Text;
            //string fullUrl = protocol + "://" + url;
            //testUrl = new TestUrlFac();
            //testUrl.TestUrl(fullUrl);
            InsertUrl();
        }

        private void btnCloseBrowsers_Click(object sender, EventArgs e)
        {
            testUrl.closeBrowsers();
        }

        private void btnTestSqlInsert_Click(object sender, EventArgs e)
        {

        }

        private void btnShowUrls_Click(object sender, EventArgs e)
        {
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
            PopulateUrlData(true);
        }
        private void PopulateUrlData(bool showDropDown)
        {
            //IEnumerable<string> urls = url.getUrlData();
            //this.cbUrl.DataSource = urls;
            //this.cbUrl.DroppedDown = showDropDown;
        }
        private void InsertUrl()
        {
            urlOpsFac = new URLOpsFac(this.cbProtocol.Text, this.cbUrl.Text);
            string message = urlOpsFac.AddUrl();
            MessageBox.Show(message);
        }

        private void dgvSitesStoredInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
