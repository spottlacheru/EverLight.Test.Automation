using EverLight.UI.Test.Automation.Common.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverLight.UI.Test.Automation.Repo
{
    public static class ComputerDatabasePageObject
    {
        public static Elements FilterEdit => Elements.Find().ById("searchbox");

        public  static Elements FilterSubmitBtn => Elements.Find().ById("searchsubmit");

        public  static Elements AddComputerBtn => Elements.Find().ById("add");

        public  static Elements ComputerNameHeader => Elements.Find().ByXPath("//*[@id='main']/table/thead/tr/th[1]/a").ByCssSelector("th.col-name.header > a");

        public  static Elements IntroducedHeader => Elements.Find().ByXPath("//*[@id='main']/table/thead/tr/th[2]/a").ByCssSelector("th.col-introduced.header > a");

        public  static Elements DiscontinuedHeader => Elements.Find().ByXPath("//*[@id='main']/table/thead/tr/th[3]/a").ByCssSelector("th.col-discontinued.header.headerSortUp > a");

        public  static Elements CompanyNameHeader => Elements.Find().ByXPath("//*[@id='main']/table/thead/tr/th[4]/a").ByCssSelector("th.col-company.header > a");

        public  static Elements NoofComputersLbl => Elements.Find().ByXPath("//*[@id='main']/h1").ByCssSelector("#main > h1");

        public  static Elements UpdateStatusLbl => Elements.Find().ByXPath("//*[@id='main']/div[1]");

        public  static Elements PreviousBtn => Elements.Find().ByXPath("//*[@id='pagination']/ul/li[1]/a");

        public  static Elements CurrentLbl => Elements.Find().ByXPath("//*[@id='pagination']/ul/li[2]/a");

        public  static Elements NextBtn => Elements.Find().ByXPath("//*[@id='pagination']/ul/li[3]/a");

    }
}
