using EverLight.UI.Test.Automation.Common.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverLight.UI.Test.Automation.Repo
{
    public class ComputerDatabasePageObject
    {
        

        public Elements FilterEdit => Elements.Find().ById("searchbox");

        public Elements FilterSubmitBtn => Elements.Find().ById("searchsubmit");

        public Elements AddComputerBtn => Elements.Find().ById("add");

        public Elements ComputerNameHeader => Elements.Find().ByXPath("//*[@id='main']/table/thead/tr/th[1]/a").ByCssSelector("th.col-name.header > a");

        public Elements IntroducedHeader => Elements.Find().ByXPath("//*[@id='main']/table/thead/tr/th[2]/a").ByCssSelector("th.col-introduced.header > a");

        public Elements DiscontinuedHeader => Elements.Find().ByXPath("//*[@id='main']/table/thead/tr/th[3]/a").ByCssSelector("th.col-discontinued.header.headerSortUp > a");

        public Elements CompanyNameHeader => Elements.Find().ByXPath("//*[@id='main']/table/thead/tr/th[4]/a").ByCssSelector("th.col-company.header > a");

        public Elements NoofComputersLbl => Elements.Find().ByXPath("//*[@id='main']/h1").ByCssSelector("#main > h1");

        public Elements UpdateStatusLbl => Elements.Find().ByXPath("//*[@id='main']/div[1]/text()");

        public Elements PreviousBtn => Elements.Find().ByXPath("//*[@id='pagination']/ul/li[1]/a");

        public Elements CurrentLbl => Elements.Find().ByXPath("//*[@id='pagination']/ul/li[2]/a");

        public Elements NextBtn => Elements.Find().ByXPath("//*[@id='pagination']/ul/li[3]/a");

    }
}
