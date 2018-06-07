using KinestInterfaces;
using KinestOps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinestFactory
{
    public class TestUrlFac : ITestIt
    {
        TestItBrowsers testItBrowsers;
        public void closeBrowsers()
        {
            testItBrowsers.closeBrowsers();
        }

        public void OpenUrl(string url)
        {
            testItBrowsers = new TestItBrowsers(url);
        }
    }
}
