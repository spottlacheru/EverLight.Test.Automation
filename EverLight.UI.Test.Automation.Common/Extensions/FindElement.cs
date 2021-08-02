using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverLight.UI.Test.Automation.Common.Extensions
{
    public static class FindElement
    {
        public static IWebElement FindElementsByLocator(this TestRunner runner, Elements elements)
        {
            IWebElement result = null;
            foreach (var ele in elements.ElementFinders)
            {
                var webelements = runner.driver.FindElements(ele);
                if (webelements.Count >= 1)
                {
                    result = webelements[0];
                    Console.WriteLine("Found the object");
                    break;
                }
                Console.WriteLine($"Warning, element was not foudn with locator [{ele}]");

            }
            if (result == null)
                throw new Exception($"Element Not found");
            return result;
        }
    }
}
