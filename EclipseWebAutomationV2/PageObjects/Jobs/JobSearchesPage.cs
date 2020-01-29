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
    class JobSearchesPage
    {
        public static IWebElement Deletejobsearchesbutton;
        public static IList<IWebElement> jobsearcheslist;
        public static void BaseURL()
        {
            string baseurl = "https://v29.wpengine.com/dashboard/job-searches/";
            WebElementExtensions.CheckURL(baseurl);
        }

        public static void SearchJobsButton()
        {
            WebElementExtensions.FindElement("LinkText", "Search Jobs");
            IWebElement jobsearchesbutton = Driver.WebDriver.FindElement(By.LinkText("Search Jobs"));
            jobsearchesbutton.WeClick();
        }

        public static void DeleteSearchJobsButton()
        {
            WebElementExtensions.FindElement("LinkText", "Delete");
            jobsearcheslist = Driver.WebDriver.FindElements(By.LinkText("Delete"));
            IWebElement Deletejobsearchesbutton = Driver.WebDriver.FindElement(By.LinkText("Delete"));
            Deletejobsearchesbutton.WeClick();
            BaseURL();
        }

        public static void JobSearchIsDeleted()
        {
            WebElementExtensions.ItemIsDeleted(jobsearcheslist, "Delete");
        }
        public static void CheckForSearch(string name)
        {
            WebElementExtensions.FindElement("LinkText", name);

        }
    }
}
