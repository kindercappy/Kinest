using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace KinestOps
{
    public class TestIt
    {
        IWebDriver driverFF;
        IWebDriver driverCH;

        public IWebDriver DriverFF
        {

            get
            {
                var ffDriverService = FirefoxDriverService.CreateDefaultService();
                ffDriverService.HideCommandPromptWindow = true;
                if (driverFF == null)
                {
                    //if (driverFF.WindowHandles.Count < 0 || driverFF.ToString() == null)
                    //{
                    driverFF = new FirefoxDriver(ffDriverService);
                    //}
                }
                return driverFF;
            }
        }
        public IWebDriver DriverCH
        {
            get
            {
                var cDriverService = ChromeDriverService.CreateDefaultService();
                cDriverService.HideCommandPromptWindow = true;
                if (driverCH == null || driverCH.ToString() == null)
                {
                    driverCH = new ChromeDriver(cDriverService);
                }
                return driverCH;
            }
        }

        public TestIt(string url)
        {
            openUrlInBrowsers(url);
        }


        private void openUrlInBrowsers(string url)
        {

            DriverFF.Navigate().GoToUrl(url);
            DriverCH.Navigate().GoToUrl(url);
        }
        /**
         * 
         *
         **/
        public void closeBrowsers()
        {
            if (DriverFF != null)
            {
                DriverFF.Quit();
            }
            if (DriverCH != null)
            {
                DriverCH.Quit();
            }
        }
    }
}
