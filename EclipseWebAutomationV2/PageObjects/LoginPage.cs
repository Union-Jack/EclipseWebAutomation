using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using EclipseWebAutomationV2.Configurations;
using EclipseWebAutomationV2.Extentions;
using EclipseWebAutomationV2.Steps;

namespace EclipseWebAutomationV2.PageObjects
{
    class LoginPage
    {
        public static void BaseURL()
        {
            string baseurl = "https://v29.wpengine.com/login";
            WebElementExtensions.CheckURL(baseurl);
        }

        public static void LoginButton()
        {
            WebElementExtensions.FindElement("Id", "login");
            IWebElement Login = Driver.WebDriver.FindElement(By.Id("login"));
            Login.WeClick();
        }

        public static void LoginFields(string username, string password, string accounttype)
        {
            WebElementExtensions.FindElement("Id", "eclipse_recruitment_username");
            WebElementExtensions.FindElement("Id", "eclipse_recruitment_password");
            WebElementExtensions.FindElement("Id", "eclipse_recruitment_role");

            IWebElement Username = Driver.WebDriver.FindElement(By.Id("eclipse_recruitment_username"));
            IWebElement Password = Driver.WebDriver.FindElement(By.Id("eclipse_recruitment_password"));
            IWebElement LoginType = Driver.WebDriver.FindElement(By.Id("eclipse_recruitment_role"));

            Username.WeSendKeys(username);
            Password.WeSendKeys(password);

            if (accounttype == "client")
            {
                LoginType.WeUseDD();
            }


        }
    }
}
