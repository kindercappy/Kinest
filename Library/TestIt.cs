using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Library
{
    public class TestIt
    {
        IWebDriver driverFF;
        IWebDriver driverCH;

        public IWebDriver DriverFF { get => driverFF; set => driverFF = value; }
        public IWebDriver DriverCH { get => driverCH; set => driverCH = value; }

        public TestIt(string url)
        {
            openUrlInBrowsers(url);
        }


        private void openUrlInBrowsers(string url)
        {
            //driverCH = new ChromeDriver();
            var driverService = FirefoxDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            DriverFF = new FirefoxDriver(driverService);
            DriverFF.Navigate().GoToUrl(url);
            //driverCH.Navigate().GoToUrl(url);
        }
    }
}
