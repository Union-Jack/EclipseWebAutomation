using EclipseWebAutomationV2.Configurations;
using EclipseWebAutomationV2.Extentions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EclipseWebAutomationV2.PageObjects.Jobs
{
    class JobApplicationsPage
    {
        public static IList<IWebElement> jobapplicationlist;
        public static void BaseURL()
        {
            string baseurl = "https://v29.wpengine.com/dashboard/job-applications/";
            WebElementExtensions.CheckURL(baseurl);
        }

        public static void DeleteApplication()
        {
            WebElementExtensions.FindElement("LinkText", "Delete");
            jobapplicationlist = Driver.WebDriver.FindElements(By.LinkText("Delete"));
            IWebElement deleteapplicationbutton = Driver.WebDriver.FindElement(By.LinkText("Delete"));
            deleteapplicationbutton.WeClick();
            BaseURL();
        }

        public static void DeleteApplicationCheck()
        {
            WebElementExtensions.ItemIsDeleted(jobapplicationlist, "Delete");
        }
    }
}
