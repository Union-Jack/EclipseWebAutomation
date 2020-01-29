using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using EclipseWebAutomationV2.Configurations;
using EclipseWebAutomationV2.Extentions;
namespace EclipseWebAutomationV2.PageObjects
{
    class HomePage
    {
        public static void BaseURL()
        {
            string baseurl = "https://v29.wpengine.com/";
            WebElementExtensions.CheckURL(baseurl);
        }
        public static void LoginLink()
        {
            WebElementExtensions.FindElement("LinkText", "Log In");
            IWebElement loginLink = Driver.WebDriver.FindElement(By.LinkText("Log In"));
            loginLink.WeClick();
        }

        public static void JobBoardLink()
        {
            WebElementExtensions.FindElement("LinkText", "Jobs");
            IWebElement jobboardLink = Driver.WebDriver.FindElement(By.LinkText("Jobs"));
            jobboardLink.WeClick();
            string nexturl = "https://v29.wpengine.com/jobs/";
            WebElementExtensions.CheckURL(nexturl);

        }
    }
}