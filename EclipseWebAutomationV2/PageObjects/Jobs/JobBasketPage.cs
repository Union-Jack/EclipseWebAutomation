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
    class JobBasketPage
    {
        public static IList<IWebElement> jobbasketlist;

        public static void BaseURL()
        {
            string baseurl = "https://v29.wpengine.com/dashboard/job-basket/";
            WebElementExtensions.CheckURL(baseurl);
        }

        public static void ApplyButton()
        {
            WebElementExtensions.FindElement("LinkText", "Apply");
            IWebElement jobbasketbutton = Driver.WebDriver.FindElement(By.LinkText("Apply"));
            jobbasketbutton.WeClick();
        }

        public static void RemoveFromBasketButton()
        {
            WebElementExtensions.FindElement("LinkText", "Remove");
            jobbasketlist = Driver.WebDriver.FindElements(By.LinkText("Remove"));
            IWebElement removefrombasketbutton = Driver.WebDriver.FindElement(By.LinkText("Remove"));
            removefrombasketbutton.WeClick();
            BaseURL();
        }

        public static void JobSearchIsDeleted()
        {
            WebElementExtensions.ItemIsDeleted(jobbasketlist, "Remove");
        }
    }
}
