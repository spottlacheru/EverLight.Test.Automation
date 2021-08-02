using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverLight.UI.Test.Automation.Common
{
    public class TestRunner : IDisposable
    {
        private readonly TestRunnerOptions options;
        public IWebDriver driver { get; set; }

        public TestRunner(TestRunnerOptions options)
        {
            var chromeoptions = new ChromeOptions();

            this.options = options;

            switch (this.options.BrowserType)
            {
                case BrowserType.Chrome:
                    this.driver = new ChromeDriver();
                    this.driver.Navigate().GoToUrl(this.options.SiteRoot);
                    break;
                case BrowserType.Firefox:
                    //TODO
                    break;
                case BrowserType.InternetExplorer:
                    //TODO
                    break;
                default:
                    throw new Exception($"Unsupported browser Type[{this.options.BrowserType}]");
            }
        }

        public void Dispose()
        {
            this.driver.Quit();
            this.driver.Dispose();
        }
    }
}
