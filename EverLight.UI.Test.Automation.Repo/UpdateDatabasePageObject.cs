using EverLight.UI.Test.Automation.Common.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverLight.UI.Test.Automation.Repo
{
   public static class UpdateDatabasePageObject
    {
        public static Elements  ComputerDatabaseLnk => Elements.Find().ByXPath("//h1/a");

        public static Elements  ComputerNameEdit => Elements.Find().ById("name");

        public static Elements  IntroducedEdit => Elements.Find().ById("introduced");

        public static Elements  DiscontinuedEdit => Elements.Find().ById("discontinued");

        public static Elements  CompanyLst => Elements.Find().ById("company");

        public static Elements  CreateBtn => Elements.Find().ByXPath("//*[@id='main']/form[1]/div/input");

        public static Elements  CancelBtn => Elements.Find().ByXPath("//*[@id='main']/form[1]/div/a");

        public static Elements  DeleteComputerBtn => Elements.Find().ByXPath("//*[@id='main']/form[2]/input");

        public static Elements  ComputerNameWrngLbl => Elements.Find().ByXPath("//*[@id='main']/form/fieldset/div[1]/div/span");

        public static Elements  IntroducedWrngLbl => Elements.Find().ById("//*[@id='main']/form/fieldset/div[2]/div/span");

        public static Elements  DiscontinuedWrngLbl => Elements.Find().ById("//*[@id='main']/form/fieldset/div[3]/div/span");
    }
}
