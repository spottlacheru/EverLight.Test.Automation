using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using EverLight.UI.Test.Automation.Common.Extensions;
using TestRunner = EverLight.UI.Test.Automation.Common.TestRunner;
using OpenQA.Selenium;
using EverLight.UI.Test.Automation.Repo;
using Shouldly;

namespace EverLight.Test.Automation.Steps
{
    [Binding]
    public sealed class CommonSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        private readonly TestRunner testRunner;

        public CommonSteps(ScenarioContext scenarioContext)
        {
            this.testRunner = _scenarioContext.Get<TestRunner>("Runner");
        }

        [Given(@"The user is on HomePage")]
        public void GivenTheUserIsOnHomePage()
        {
            //Place Holder
        }

        [When(@"The user clicks on (.*) button")]
        public void WhenTheUserClicksOnAddComputerButton(string element)
        {
            this.testRunner.FindElementsByID(element).Click();
        }

        [Then(@"The user enter (.*) in field (.*)")]
        public void ThenTheUserEnterTextInFieldElement(string text, string element)
        {
            this.testRunner.FindElementsByID(element).SendKeys(text);
        }

        [Then(@"The user select item lstitme from list")]
        public void ThenTheUserSelectItemLstitmeFromList()
        {
            this.testRunner.SelectListItem(UpdateDatabasePageObject.CompanyLst, "ACVS");
            
        }

        [Then(@"The user see confirmation message")]
        public void ThenTheUserSeeConfirmationMessage()
        {
          this.testRunner.GetText(ComputerDatabasePageObject.UpdateStatusLbl).ShouldContain("Computer mycomp has been created");
        }

        [When(@"The user clicks on Create Btn")]
        public void WhenTheUserClicksOnCreateBtn()
        {
            this.testRunner.ClickElement(UpdateDatabasePageObject.CreateBtn);
        }


    }
}
