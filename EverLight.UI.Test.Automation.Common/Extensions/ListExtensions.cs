using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverLight.UI.Test.Automation.Common.Extensions
{
    public static class ListExtensions
    {
        public static TestRunner SelectListItem(this TestRunner runner, Elements element, string listitem)
        {
            var education = runner.FindElementsByLocator(element);

            education.Click();

            var selectElement = new SelectElement(education);

            selectElement.SelectByText(listitem);

            return runner;

        }

    }
}
