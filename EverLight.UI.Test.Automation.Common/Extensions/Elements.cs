using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverLight.UI.Test.Automation.Common.Extensions
{
    public class Elements
    {
        public List<By> ElementFinders = new List<By>();

        public static Elements Find()
        {
            return new Elements();
        }
    }


    public static class ElementFinderBuilderExtensions
    {
        public static Elements ByXPath(this Elements builder, string xPath)
        {
            builder.ElementFinders.Add(By.XPath(xPath));

            return builder;
        }

        public static Elements ById(this Elements builder, string xPath)
        {
            builder.ElementFinders.Add(By.Id(xPath));

            return builder;
        }

        public static Elements ByCssSelector(this Elements builder, string xPath)
        {
            builder.ElementFinders.Add(By.CssSelector(xPath));

            return builder;
        }

        public static Elements ByName(this Elements builder, string xPath)
        {
            builder.ElementFinders.Add(By.Name(xPath));

            return builder;
        }

        public static Elements ByLinkText(this Elements builder, string xPath)
        {
            builder.ElementFinders.Add(By.LinkText(xPath));

            return builder;
        }

        public static Elements ByClassName(this Elements builder, string xPath)
        {
            builder.ElementFinders.Add(By.ClassName(xPath));

            return builder;
        }

        public static Elements ByTagName(this Elements builder, string xPath)
        {
            builder.ElementFinders.Add(By.TagName(xPath));

            return builder;
        }
    }
}
