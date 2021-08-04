using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverLight.UI.Test.Automation.Common.Extensions
{
    public static class AlertExtensions
    {
        static string alerttext;

        /// <summary>
        /// Action on Alert
        /// </summary>
        /// <param name="runner"></param>
        /// <param name="accept">True to accept alert; flase to dismiss</param>
        /// <param name="text">Optional parm to pass text into alert</param>
        /// <returns></returns>
        public static TestRunner AcceptAlert(this TestRunner runner, bool accept, string text = null)
        {
            var alertpopup = runner.driver.SwitchTo().Alert();
            alerttext = alertpopup.Text;

            if (text != null)
                alertpopup.SendKeys(text);

            if (accept)
                alertpopup.Accept();
            else
                alertpopup.Dismiss();

            return runner;
        }

        public static string VerifyAcceptAlertText(this TestRunner runner)
        {
            return alerttext;
        }
    }
}
