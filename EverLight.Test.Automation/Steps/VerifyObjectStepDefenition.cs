using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using EverLight.UI.Test.Automation.Common.Extensions;
using TestRunner = EverLight.UI.Test.Automation.Common.TestRunner;

namespace EverLight.Test.Automation.Steps
{
    [Binding]
    public sealed class VerifyObjectStepDefenition
    {
        private readonly TestRunner testRunner;
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public VerifyObjectStepDefenition(ScenarioContext scenarioContext)
        {
            this.testRunner = _scenarioContext.Get<TestRunner>("Runner");
        }

        [Given(@"I have navigated to portal")]
        public void GivenIHaveNavigatedToPortal()
        {
            
        }

        [Then(@"The user could see (.*) List")]
        public void ThenTheUserCouldSeeComputerDatabaseList(string objectName)
        {
            
        }

       

    }
}
