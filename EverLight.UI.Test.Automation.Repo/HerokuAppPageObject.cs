using EverLight.UI.Test.Automation.Common.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverLight.UI.Test.Automation.Repo
{
   public static class HerokuAppPageObject
    {
        public static Elements  JSAlertBtn => Elements.Find().ByXPath("//button[.='Click for JS Alert']").ByXPath("//*[@id='content']/div/ul/li[1]/button");

        public static Elements  JSConfirmBtn => Elements.Find().ByXPath("button[onclick='jsConfirm()']").ByXPath("//*[@id='content']/div/ul/li[2]/button");

        public static Elements  JSPrompt => Elements.Find().ByXPath("button[onclick='jsPrompt()']").ByXPath("//*[@id='content']/div/ul/li[3]/button");

        public static Elements Result => Elements.Find().ById("result");
    }
}
