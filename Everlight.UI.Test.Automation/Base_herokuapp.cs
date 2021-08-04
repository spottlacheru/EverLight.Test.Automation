using EverLight.UI.Test.Automation.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace Everlight.UI.Test.Automation
{
    [TestClass]
   public  class Base_herokuapp : Faker
    {
        public TestRunner testRunner { get; set; }

        public TestRunnerOptions options;

        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void BeforeTest()
        {
            options = this.GenerateOptions();

            this.testRunner = new TestRunner(options);

            TestContext.Properties.Add("Runner", this.testRunner);
        }

        [TestCleanup]
        public void Cleanup()
        {
            this.testRunner.driver.Quit();
        }

        private TestRunnerOptions GenerateOptions()
        {
            return new TestRunnerOptions
            {
                SiteRoot = "https://the-internet.herokuapp.com/javascript_alerts",
                BrowserType = BrowserType.Chrome,
                TakeScreenshots = true,
                EnabelConsoleLogging = true,
                TestName = TestContext.TestName

            };
        }
    }
}
