using BoDi;
using EverLight.UI.Test.Automation.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TestRunner = EverLight.UI.Test.Automation.Common.TestRunner;



namespace EverLight.Test.Automation.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        private TestRunner testRunner;
        private readonly IObjectContainer _objectContainer;
        private readonly ScenarioContext scenarioContext;
        private readonly string url;
        

        public Hooks(ScenarioContext injectedContext, IObjectContainer objectContainer)
        {
            scenarioContext = injectedContext;
            _objectContainer = objectContainer;
            //var configuration = GetConfiguration();
            //this.url = configuration.GetSection("url").Value;
        }

        [BeforeTestRun]
        public static void InitializeTest()
        {
            //var configuration = GetConfiguration();
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            var options = GenerateOptions();
            this.testRunner = new TestRunner(options);
            this.scenarioContext.Add("Runner", testRunner);

        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (this.testRunner != null)
            {
                this.testRunner.Dispose();
            }
        }

        private TestRunnerOptions GenerateOptions()
        {
            return new TestRunnerOptions
            {
                SiteRoot = this.url,
                BrowserType = BrowserType.Chrome,

            };
        }

        //private static IConfiguration GetConfiguration()
        //{
        //    var builder = new ConfigurationBuilder();

        //    builder
        //        .AddJsonFile("appsettings.json");

        //    return builder.Build();
        //}

    }
}
