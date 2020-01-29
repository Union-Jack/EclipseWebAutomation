using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EclipseWebAutomationV2.Configurations;
using System.Threading;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using NLog;
using OpenQA.Selenium.Support.Extensions;
using System.Drawing.Imaging;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;

namespace EclipseWebAutomationV2.Extentions
{
    public static class WebElementExtensions
    {
        public static void Screenshot()
        {
            string currenttest = TestContext.CurrentContext.Test.Name;
            Reporter.path = $"D:\\temp\\EclipseWebAutomationV2\\{currenttest}_Exeption_Screenshot.Jpeg";
            Screenshot ss = ((ITakesScreenshot)Driver.WebDriver).GetScreenshot();
            ss.SaveAsFile($"{Reporter.path}", ScreenshotImageFormat.Jpeg);
        }

        public static void WeElementToBeClickable(this IWebElement element, int sec = 10)
        {
            var wait = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(sec));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public static void WeElementToBeClickable(this By element, int sec = 10)
        {
            var wait = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(sec));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public static bool WeElementIsDisplayed(this IWebElement element, int sec = 10)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(sec));
                return wait.Until(d => element.Displayed && element.Enabled);
            }
            catch (NoSuchElementException)
            {
                Thread.Sleep(1000);
                WebDriverWait wait = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(sec));
                return wait.Until(d => element.Displayed && element.Enabled);

            }
        }

        public static void WeClick(this IWebElement element, int sec = 10)
        {
            try
            {
                element.WeElementIsDisplayed();
                element.WeElementToBeClickable(sec);
                element.Click();
            }
            catch (StaleElementReferenceException)
            {
                element.WeElementIsDisplayed();
                element.WeElementToBeClickable(sec);
                element.Click();
            }
            catch (Exception e)
            {
                Reporter.exeptionmessage = e.ToString();
                Screenshot();
                Driver.Close();
                throw new Exception("Unable to click on element", e);
            }
        }

        public static void WeClick(this By element)
        {
            try
            {
                element.WeElementToBeClickable();
                Driver.WebDriver.FindElement(element).Click();
            }
            catch (StaleElementReferenceException)
            {
                Driver.WebDriver.FindElement(element).Click();
            }
            catch (Exception e)
            {
                Reporter.exeptionmessage = e.ToString();
                Screenshot();
                Driver.Close();
                throw new Exception("Unable to click on element", e);
            }
        }

        public static void WeSendKeys(this IWebElement element, string text, int sec = 10, bool clearFirst = false)
        {
            try
            {
                element.WeElementIsDisplayed(sec);
                element.WeElementToBeClickable(sec);
                if (clearFirst) element.Clear();
                element.SendKeys(text);
            }
            catch (StaleElementReferenceException)
            {
                element.SendKeys(text);
            }
            catch (Exception e)
            {
                Reporter.exeptionmessage = e.ToString();
                Screenshot();
                Driver.Close();
                throw new Exception("Unable to send keys to element", e);
            }
        }

        public static void WeSendKeys(this By element, string text, int sec = 10, bool clearFirst = false)
        {
            try
            {
                element.WeElementToBeClickable(sec);
                if (clearFirst) Driver.WebDriver.FindElement(element).Clear();
                Driver.WebDriver.FindElement(element).SendKeys(text);
            }
            catch (Exception e)
            {
                Reporter.exeptionmessage = e.ToString();
                Screenshot();
                Driver.Close();
                throw new Exception("Unable to send keys to element", e);
            }
        }

        public static void WeUseDD(this IWebElement element, int sec = 10, bool clearFirst = false)
        {
            try
            {
                element.WeElementToBeClickable(sec);
                element.WeElementIsDisplayed(sec);
                if (clearFirst) element.Clear();
                element.SendKeys(Keys.Down);
                element.SendKeys(Keys.Enter);
            }
            catch (StaleElementReferenceException)
            {
                element.SendKeys(Keys.Down);
                element.SendKeys(Keys.Enter);
            }
            catch (Exception e)
            {
                Reporter.exeptionmessage = e.ToString();
                Screenshot();
                Driver.Close();
                throw new Exception("Unable to use dropdown", e);
            }
        }

        public static void WeUseDD(this By element, int sec = 10, bool clearFirst = false)
        {
            try
            {
                element.WeElementToBeClickable(sec);
                if (clearFirst) Driver.WebDriver.FindElement(element).Clear();
                Driver.WebDriver.FindElement(element).SendKeys(Keys.Down);
                Driver.WebDriver.FindElement(element).SendKeys(Keys.Enter);
            }
            catch (Exception e)
            {
                Reporter.exeptionmessage = e.ToString();
                Screenshot();
                Driver.Close();
                throw new Exception("Unable to use dropdown", e);
            }
        }

        public static void FindElement(string type, string element, int sec = 10)
        {
            try
            {
                if (type == "Id")
                {
                    var wait = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(sec));
                    wait.Until(ExpectedConditions.ElementIsVisible(By.Id(element)));
                    IWebElement check = Driver.WebDriver.FindElement(By.Id(element));
                }
                else if (type == "Name")
                {
                    var wait = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(sec));
                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name(element)));
                    IWebElement check = Driver.WebDriver.FindElement(By.Name(element));
                }
                else if (type == "LinkText")
                {
                    var wait = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(sec));
                    wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(element)));
                    IWebElement check = Driver.WebDriver.FindElement(By.LinkText(element));
                }
                else if (type == "ClassName")
                {
                    var wait = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(sec));
                    wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(element)));
                    IWebElement check = Driver.WebDriver.FindElement(By.ClassName(element));
                }
                else if (type == "CssSelector")
                {
                    var wait = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(sec));
                    wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(element)));
                    IWebElement check = Driver.WebDriver.FindElement(By.CssSelector(element));
                }
                else if (type == "XPath")
                {
                    var wait = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(sec));
                    wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(element)));
                    IWebElement check = Driver.WebDriver.FindElement(By.XPath(element));
                }
                else
                {
                    throw new Exception("Add element type to find element method in WEextensions");
                }
            }
            catch (Exception e)
            {
                Reporter.exeptionmessage = e.ToString();
                Screenshot();
                Driver.Close();
                throw new Exception("Unable to locate element", e);
            }

        }


        public static void CheckURL(string url, int sec = 10)
        {

            try
            {
                var wait = new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(sec));
                wait.Until(ExpectedConditions.UrlContains(url));
            }
            catch (Exception e)
            {
                Reporter.exeptionmessage = e.ToString();
                Screenshot();
                Driver.Close();
                throw new Exception("URL did not match expected URL", e);
            }
        }

        public static void FileIsDownloaded(string file)
        {
            try
            {
                File.Exists($@"C:\Users\Jack-\Downloads\{file}");
                File.Delete($@"C:\Users\Jack-\Downloads\{file}");
            }
            catch (Exception e)
            {
                Reporter.exeptionmessage = e.ToString();
                Screenshot();
                Driver.Close();
                throw new Exception("File does not exist", e);
            }
        }

        public static void ItemIsDeleted(IList<IWebElement> itemsinlist, string element)
        {
            try
            {
                int numofitems = itemsinlist.Count;
                IList<IWebElement> newlist = Driver.WebDriver.FindElements(By.LinkText($"{element}"));
                int numofnewitems = newlist.Count;
                Assert.IsTrue(numofitems > numofnewitems);
            }

            catch (Exception e)
            {
                Reporter.exeptionmessage = e.ToString();
                Screenshot();
                Driver.Close();
                throw new Exception("The item was not deleted", e);
            }
        }


        public static void ComparePostedDates(IList<IWebElement> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                string currentitem = list[i].Text;
                string nextitem = list[i + 1].Text;
                var currenttrim = currentitem.Split(':')[1].Trim();
                var nexttrim = nextitem.Split(':')[1].Trim();

                DateTime date = DateTime.ParseExact(currenttrim, "dd/MM/yyyy", null);
                DateTime nextdate = DateTime.ParseExact(nexttrim, "dd/MM/yyyy", null);

                try
                {
                    Assert.IsTrue(date.Date >= nextdate.Date);
                }
                catch (Exception e)
                {
                    Reporter.exeptionmessage = e.ToString();
                    Screenshot();
                    Driver.Close();
                    throw new Exception("The item was not deleted", e);
                }

            }
        }
        public static void CompareStartDates(IList<IWebElement> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                string currentitem = list[i].FindElement(By.CssSelector(".vac-val")).Text;
                string nextitem = list[i + 1].FindElement(By.CssSelector(".vac-val")).Text;
                DateTime date = DateTime.Now;
                DateTime nextdate = DateTime.Now;

                if (currentitem != "Immediate")
                {
                    date = DateTime.Parse(currentitem);

                }

                if (nextitem != "Immediate")
                {
                    nextdate = DateTime.Parse(nextitem);
                }

                try
                {
                    Assert.IsTrue(date.Date >= nextdate.Date);
                }
                catch (Exception e)
                {
                    Reporter.exeptionmessage = e.ToString();
                    Screenshot();
                    Driver.Close();
                    throw new Exception("The item was not deleted", e);
                }
            }
        }

        public static void ScrollToElement(IWebElement element)
        {
            ((IJavaScriptExecutor)Driver.WebDriver).ExecuteScript("arguments[0].scrollIntoView();", element);
        }

        public static void SimulateClick(IWebElement element)
        {
            ((IJavaScriptExecutor)Driver.WebDriver).ExecuteScript("arguments[0].click()", element);
        }
    }
}
