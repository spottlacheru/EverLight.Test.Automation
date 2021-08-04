using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverLight.UI.Test.Automation.Common.Extensions
{
    public static class TableExtensions
    {
        public static bool VerifyColomnValues(this TestRunner runner, string colomnnumber, string value)
        {
            bool flag = true;
            var rowcount = runner.driver.FindElements(By.XPath($@"//*[@id='main']/table/tbody/tr/td[{colomnnumber}]"));

            for (int i = 1; i <= rowcount.Count; i++)
            {
                var coloum = runner.driver.FindElements(By.XPath($@"//*[@id='main']/table/tbody/tr[{i}]/td[{colomnnumber}]"))[0].Text;

                if (!coloum.Contains(value,StringComparison.OrdinalIgnoreCase))
                    return false;
            }

            return flag;
        }

        public static int FilterResult(this TestRunner runner)
        {
            var count =  runner.driver.FindElements(By.XPath($@"//*[@id='main']/table/tbody/tr/td[1]")).Count;

            return count;

        }
    }
}
