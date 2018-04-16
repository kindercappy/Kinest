using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;
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
            //var driverService = PhantomJSDriverService.CreateDefaultService();
            //driverService.HideCommandPromptWindow = true;
            //var driver = new PhantomJSDriver(driverService);
            this.cbProtocol.SelectedIndex = 0;
        }

        private void btnOpenUrl_Click(object sender, EventArgs e)
        {
            string url = this.txtUrl.Text;
            string protocol = this.cbProtocol.Text;
            string fullUrl = protocol + "://" + url;
           testUrl = new TestIt(fullUrl);
        }

        private void btnCloseBrowsers_Click(object sender, EventArgs e)
        {
            testUrl.DriverFF.Close();
        }
    }
}
