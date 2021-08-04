using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;

namespace Everlight.UI.Test.Automation
{
    [TestClass]
    public class APITest
    {
        RestClient client;

        RestRequest request;

        [TestMethod]
        public void UpdateComputerDetails()
        {
            request.AddHeader("Referer", "https://computer-database.gatling.io/computers/381");
            request.AddParameter("name", "ACE");
            request.AddParameter("introduced", "2010-03-22");
            request.AddParameter("discontinued", "2010-03-23");
            request.AddParameter("company", "15");
            IRestResponse response = client.Execute(request);
            response.StatusCode.ShouldBe(System.Net.HttpStatusCode.OK);
            Console.WriteLine(response.Content);
        }

        [TestMethod]
        public void UpdateComputer_Invalid_IntroducedDate_Details()
        {
            request.AddHeader("Referer", "https://computer-database.gatling.io/computers/381");
            request.AddParameter("name", "ACE");
            request.AddParameter("introduced", "200-0-22");
            request.AddParameter("discontinued", "2010-03-23");
            request.AddParameter("company", "15");
            IRestResponse response = client.Execute(request);
            response.StatusCode.ShouldBe(System.Net.HttpStatusCode.BadRequest);
            Console.WriteLine(response.Content);
        }

        [TestMethod]
        public void UpdateComputer_Invalid_DiscontinuedDate_Details()
        {
            request.AddHeader("Referer", "https://computer-database.gatling.io/computers/381");
            request.AddParameter("name", "ACE");
            request.AddParameter("introduced", "2010-03-23");
            request.AddParameter("discontinued", "2-03-23");
            request.AddParameter("company", "15");
            IRestResponse response = client.Execute(request);
            response.StatusCode.ShouldBe(System.Net.HttpStatusCode.BadRequest);
            Console.WriteLine(response.Content);
        }

  

        [TestInitialize]
        public void TestInti()
        {
            client = new RestClient("https://computer-database.gatling.io/computers/381");
            client.Timeout = -1;
            request = new RestRequest(Method.POST);
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Cache-Control", "max-age=0");
            request.AddHeader("sec-ch-ua", "\"Chromium\";v=\"92\", \" Not A;Brand\";v=\"99\", \"Google Chrome\";v=\"92\"");
            request.AddHeader("sec-ch-ua-mobile", "?0");
            request.AddHeader("Upgrade-Insecure-Requests", "1");
            request.AddHeader("Origin", "https://computer-database.gatling.io");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            client.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/92.0.4515.107 Safari/537.36";
            request.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
            request.AddHeader("Sec-Fetch-Site", "same-origin");
            request.AddHeader("Sec-Fetch-Mode", "navigate");
            request.AddHeader("Sec-Fetch-User", "?1");
            request.AddHeader("Sec-Fetch-Dest", "document");

            request.AddHeader("Accept-Language", "en-US,en;q=0.9");
        }

    }
}
