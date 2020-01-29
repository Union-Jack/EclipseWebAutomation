using EclipseWebAutomationV2.Configurations;
using EclipseWebAutomationV2.Extentions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EclipseWebAutomationV2.PageObjects.Candidate
{
    class CandidateDashboard
    {
        public static void BaseURL()
        {
            string baseurl = "https://v29.wpengine.com/dashboard/";
            WebElementExtensions.CheckURL(baseurl);
        }

        public static void ProfileButton()
        {
            WebElementExtensions.FindElement("LinkText", "Profile");
            IWebElement Login = Driver.WebDriver.FindElement(By.LinkText("Profile"));
            Login.WeClick();
        }

        public static void CVButton()
        {
            WebElementExtensions.FindElement("LinkText", "CV");
            IWebElement Login = Driver.WebDriver.FindElement(By.LinkText("CV"));
            Login.WeClick();
        }

        public static void TimesheetsButton()
        {
            WebElementExtensions.FindElement("LinkText", "Timesheets");
            IWebElement Login = Driver.WebDriver.FindElement(By.LinkText("Timesheets"));
            Login.WeClick();
        }

        public static void JobSearchesButton()
        {
            WebElementExtensions.FindElement("LinkText", "Job Searches");
            IWebElement Login = Driver.WebDriver.FindElement(By.LinkText("Job Searches"));
            Login.WeClick();
        }

        public static void JobBasketButton()
        {
            WebElementExtensions.FindElement("LinkText", "Job Basket");
            IWebElement Login = Driver.WebDriver.FindElement(By.LinkText("Job Basket"));
            Login.WeClick();
        }

        public static void JobApplicationsButton()
        {
            WebElementExtensions.FindElement("LinkText", "Job Applications");
            IWebElement Login = Driver.WebDriver.FindElement(By.LinkText("Job Applications"));
            Login.WeClick();
        }

        public static void ChangePasswordButton()
        {
            WebElementExtensions.FindElement("LinkText", "Change Password");
            IWebElement Login = Driver.WebDriver.FindElement(By.LinkText("Change Password"));
            Login.WeClick();
        }

        public static void JobsButton()
        {
            WebElementExtensions.FindElement("LinkText", "Jobs");
            IWebElement Login = Driver.WebDriver.FindElement(By.LinkText("Jobs"));
            Login.WeClick();
        }
    }
}
