using EverLight.UI.Test.Automation.Common.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverLight.UI.Test.Automation.Repo
{
   public class UpdateDatabasePageObject
    {
        public Elements ComputerDatabaseLnk => Elements.Find().ByXPath("//h1/a");

        public Elements ComputerNameEdit => Elements.Find().ById("name");

        public Elements IntroducedEdit => Elements.Find().ById("introduced");

        public Elements DiscontinuedEdit => Elements.Find().ById("discontinued");

        public Elements CompanyLst => Elements.Find().ById("company");

        public Elements CreateBtn => Elements.Find().ByXPath("//*[@id='main']/form[1]/div/input");

        public Elements CancelBtn => Elements.Find().ByXPath("//*[@id='main']/form[1]/div/a");

        public Elements DeleteComputerBtn => Elements.Find().ByXPath("//*[@id='main']/form[2]/input");

        public Elements ComputerNameWrngLbl => Elements.Find().ByXPath("//*[@id='main']/form/fieldset/div[1]/div/span");

        public Elements IntroducedWrngLbl => Elements.Find().ById("//*[@id='main']/form/fieldset/div[2]/div/span");

        public Elements DiscontinuedWrngLbl => Elements.Find().ById("//*[@id='main']/form/fieldset/div[3]/div/span");



    }
}
