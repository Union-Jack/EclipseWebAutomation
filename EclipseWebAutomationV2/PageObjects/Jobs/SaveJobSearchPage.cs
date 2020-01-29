using EclipseWebAutomationV2.Configurations;
using EclipseWebAutomationV2.Extentions;
using EclipseWebAutomationV2.Steps;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EclipseWebAutomationV2.PageObjects.Jobs
{
    class SaveJobSearchPage
    {
        public static void BaseURL()
        {
            string baseurl = "https://v29.wpengine.com/dashboard/save-job-search/";
            WebElementExtensions.CheckURL(baseurl);
        }

        public static void SearchName(string name)
        {
            WebElementExtensions.FindElement("Id", "eclipse_recruitment_name");
            IWebElement searchname = Driver.WebDriver.FindElement(By.Id("eclipse_recruitment_name"));
            searchname.WeSendKeys(name);
        }

        public static void SaveButton()
        {
            WebElementExtensions.FindElement("Id", "save_search");
            IWebElement savebutton = Driver.WebDriver.FindElement(By.Id("save_search"));
            savebutton.WeClick();
        }

        public static void BackToJobBoardButton()
        {
            WebElementExtensions.FindElement("CssSelector", ".back-button.button");
            IWebElement backtojobboard = Driver.WebDriver.FindElement(By.CssSelector(".back-button.button"));
            backtojobboard.WeClick();
        }

        public static void LogoutButton()
        {
            WebElementExtensions.FindElement("ClassName", "logout-link");
        }
    }
}
