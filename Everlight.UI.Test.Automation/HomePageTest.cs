using EverLight.UI.Test.Automation.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EverLight.UI.Test.Automation.Common.Extensions;
using EverLight.UI.Test.Automation.Repo;
using Shouldly;

namespace Everlight.UI.Test.Automation
{
    [TestClass]
    public class HeroKuApp_AlertsTest : Base
    {

        private TestRunner TestRunner { get; set; }

        /// <summary>
        /// Verify all the page elements are visible
        /// </summary>
        [TestMethod]
        [TestCategory("SmokeTest")]
        public void VerifyHomePage()
        {
            this.TestRunner = (TestRunner)TestContext.Properties["Runner"];

            this.TestRunner.VerifyElement(ComputerDatabasePageObject.AddComputerBtn).ShouldBeGreaterThan(0, "Computer Button element not found");

            this.TestRunner.VerifyElement(ComputerDatabasePageObject.FilterEdit).ShouldBeGreaterThan(0, "Filter Edit element not found");

            this.TestRunner.VerifyElement(ComputerDatabasePageObject.FilterSubmitBtn).ShouldBeGreaterThan(0, "Filter Submit Button element not found");

            this.TestRunner.VerifyElement(ComputerDatabasePageObject.ComputerNameHeader).ShouldBeGreaterThan(0, "Computer Name Header element not found");

            this.TestRunner.VerifyElement(ComputerDatabasePageObject.IntroducedHeader).ShouldBeGreaterThan(0, "Introduced Header element not found");

            this.TestRunner.VerifyElement(ComputerDatabasePageObject.DiscontinuedHeader).ShouldBeGreaterThan(0, "Discontinued Header element not found");

            this.TestRunner.VerifyElement(ComputerDatabasePageObject.CompanyNameHeader).ShouldBeGreaterThan(0, "Company Name Header element not found");

            this.TestRunner.VerifyElement(ComputerDatabasePageObject.NoofComputersLbl).ShouldBeGreaterThan(0, "No of Computers Lbl  element not found");

            this.TestRunner.VerifyElement(ComputerDatabasePageObject.PreviousBtn).ShouldBeGreaterThan(0, "Previous Button element not found");

            this.TestRunner.VerifyElement(ComputerDatabasePageObject.CurrentLbl).ShouldBeGreaterThan(0, "Current Lable element not found");

            this.TestRunner.VerifyElement(ComputerDatabasePageObject.NextBtn).ShouldBeGreaterThan(0, "Next Button element not found");
        }

       

    }
}
