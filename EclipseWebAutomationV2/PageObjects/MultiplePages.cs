using EclipseWebAutomationV2.Configurations;
using EclipseWebAutomationV2.Extentions;
using EclipseWebAutomationV2.Steps;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EclipseWebAutomationV2.PageObjects
{
    class MultiplePages
    {
        public static void Keyword(string keyword)
        {
            WebElementExtensions.FindElement("Id", "keywords");
            IWebElement loginLink = Driver.WebDriver.FindElement(By.Id("keywords"));
            loginLink.WeSendKeys(keyword);
        }

        public static void Country(string country)
        {
            WebElementExtensions.FindElement("Name", "country[]");
            IWebElement countrylist = Driver.WebDriver.FindElement(By.Name("country[]"));
            var selectElement = new SelectElement(countrylist);
            selectElement.SelectByText(country);

        }

        public static void Region(string region)
        {
            WebElementExtensions.FindElement("Name", "region[]");
            IWebElement regionlist = Driver.WebDriver.FindElement(By.Name("region[]"));
            var selectElement = new SelectElement(regionlist);
            selectElement.SelectByText(region);
        }

        public static void Location(string location)
        {
            WebElementExtensions.FindElement("Name", "location[]");
            IWebElement locationlist = Driver.WebDriver.FindElement(By.Name("location[]"));
            var selectElement = new SelectElement(locationlist);
            selectElement.SelectByText(location);
        }

        public static void Industry(string industry)
        {
            WebElementExtensions.FindElement("Name", "industry[]");
            IWebElement industrylist = Driver.WebDriver.FindElement(By.Name("industry[]"));
            var selectElement = new SelectElement(industrylist);
            selectElement.SelectByText(industry);
        }

        public static void Discipline(string discipline)
        {
            WebElementExtensions.FindElement("Name", "discipline[]");
            IWebElement disciplinelist = Driver.WebDriver.FindElement(By.Name("discipline[]"));
            var selectElement = new SelectElement(disciplinelist);
            selectElement.SelectByText(discipline);
        }
        public static void GoButton()
        {
            WebElementExtensions.FindElement("CssSelector", ".button.search.search-button");
            IWebElement gobutton = Driver.WebDriver.FindElement(By.CssSelector(".button.search.search-button"));
            gobutton.WeClick();
        }
    }
}
