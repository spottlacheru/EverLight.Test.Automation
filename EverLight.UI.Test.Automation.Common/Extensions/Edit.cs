using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverLight.UI.Test.Automation.Common.Extensions
{
    public static class Edit
    {
        public static TestRunner EnterText(this TestRunner runner, Elements element, string text)
        {
            var webele = runner.FindElementsByLocator(element);
            webele.Click();
            webele.SendKeys(text);
            Console.WriteLine($"Entered text [{text}]");
            return runner;
        }
    }
}
