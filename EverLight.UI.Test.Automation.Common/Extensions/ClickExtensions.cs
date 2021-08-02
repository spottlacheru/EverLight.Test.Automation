using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverLight.UI.Test.Automation.Common.Extensions
{
   public static class ClickExtensions
    {
        public static TestRunner ClickElement(this TestRunner runner, Elements element)
        {
            runner.FindElementsByLocator(element).Click();
            Console.WriteLine("Clicked on Element");
            return runner;
        }
    }
}
