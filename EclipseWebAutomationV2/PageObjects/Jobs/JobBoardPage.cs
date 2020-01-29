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
    class JobBoardPage
    {
        public static void BaseURL()
        {
            string baseurl = "https://v29.wpengine.com/jobs/";
            WebElementExtensions.CheckURL(baseurl);
        }
        public static void SaveSearch()
        {
            WebElementExtensions.FindElement("ClassName", "save-search-link");
            IWebElement savesearchbutton = Driver.WebDriver.FindElement(By.ClassName("save-search-link"));
            savesearchbutton.WeClick();
        }

        public static void MoreDetails()
        {
            WebElementExtensions.FindElement("ClassName", "details-link");
            IWebElement moredetails = Driver.WebDriver.FindElement(By.ClassName("details-link"));
            moredetails.WeClick();
        }

        public static void AddToBasket()
        {
            IWebElement requestdetails;
            WebElementExtensions.FindElement("LinkText", "Add to Basket");
            requestdetails = Driver.WebDriver.FindElement(By.LinkText("Add to Basket"));
            requestdetails.WeClick();
        }

        public static void AddedToBasket()
        {
            WebElementExtensions.FindElement("ClassName", "job-link");
        }

        public static void RequestDetails()
        {
            WebElementExtensions.FindElement("LinkText", "Request Details");
            IWebElement requestdetails = Driver.WebDriver.FindElement(By.LinkText("Request Details"));
            WebElementExtensions.ScrollToElement(requestdetails);
            WebElementExtensions.SimulateClick(requestdetails);
        }

        public static void YourNameField(string name)
        {
            WebElementExtensions.FindElement("Name", "your-name");
            IWebElement yourname = Driver.WebDriver.FindElement(By.Name("your-name"));
            yourname.WeSendKeys(name);
        }

        public static void YourEmailField(string email)
        {
            WebElementExtensions.FindElement("Name", "your-email");
            IWebElement youremail = Driver.WebDriver.FindElement(By.Name("your-email"));
            youremail.WeSendKeys(email);
        }
        public static void SubjectField(string subject)
        {
            WebElementExtensions.FindElement("Name", "your-subject");
            IWebElement subjectfield = Driver.WebDriver.FindElement(By.Name("your-subject"));
            subjectfield.WeSendKeys(subject);
        }
        public static void YourMessageField(string message)
        {
            WebElementExtensions.FindElement("Name", "your-message");
            IWebElement youremail = Driver.WebDriver.FindElement(By.Name("your-message"));
            youremail.WeSendKeys(message);
        }
        public static void SendButton()
        {
            WebElementExtensions.FindElement("Name", "submit-request-detail");
            IWebElement send = Driver.WebDriver.FindElement(By.Name("submit-request-detail"));
            WebElementExtensions.ScrollToElement(send);
            WebElementExtensions.SimulateClick(send);
        }

        public static void RequestWasSent()
        {
            WebElementExtensions.FindElement("Id", "eclipse_confirmation_msg_consultant");
        }

        public static void SortByLatest()
        {
            WebElementExtensions.FindElement("CssSelector", ".vacancy-date.date");
            IList<IWebElement> posteddate = Driver.WebDriver.FindElements(By.CssSelector(".vacancy-date.date"));
            WebElementExtensions.ComparePostedDates(posteddate);
        }

        public static void SortByStartDate()
        {
            WebElementExtensions.FindElement("Id", "eclipse_recruitment_vacancy_sort");
            IWebElement sortby = Driver.WebDriver.FindElement(By.Id("eclipse_recruitment_vacancy_sort"));
            sortby.WeSendKeys(Keys.Down);
        }

        public static void CheckStartDate()
        {
            WebElementExtensions.FindElement("CssSelector", ".start-date");
            IList<IWebElement> startdate = Driver.WebDriver.FindElements(By.CssSelector(".start-date"));
            WebElementExtensions.CompareStartDates(startdate);
        }

    }
}
