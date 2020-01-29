using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EclipseWebAutomationV2.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoDi;
using TechTalk.SpecFlow;

namespace EclipseWebAutomationV2.Configurations
{
    public class Driver
    {
        public static IWebDriver WebDriver;
        public static string BaseURL = ConfigurationManager.AppSettings["URL"];
        public static void Init(string Browser)
        {
            switch (Browser)
            {
                case "Chrome":
                    WebDriver = new ChromeDriver();

                    break;
                case "IE":
                    WebDriver = new InternetExplorerDriver();
                    break;
                case "Firefox":
                    FirefoxOptions options = new FirefoxOptions();
                    options.SetPreference("browser.download.folderList", 2);
                    options.SetPreference("browser.download.dir", "C:\\Users\\Jack-\\Downloads");
                    options.SetPreference("browser.download.useDownloadDir", true);
                    options.SetPreference("browser.helperApps.neverAsk.saveToDisk", "text/html");
                    options.SetPreference("pdfjs.disabled", true);
                    WebDriver = new FirefoxDriver(options);
                    break;
            }
            WebDriver.Manage().Window.Maximize();
            Goto(BaseURL);

        }
        public static string Title
        {
            get { return WebDriver.Title; }
        }
        public static IWebDriver GetDriver
        {
            get { return WebDriver; }
        }
        public static void Goto(string url)
        {
            WebDriver.Url = url;
        }
        public static void Close()
        {
            WebDriver.Quit();
        }
    }
}