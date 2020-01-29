using EclipseWebAutomationV2.Configurations;
using EclipseWebAutomationV2.Extentions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EclipseWebAutomationV2.PageObjects
{
    class AccessPage
    {
        public static void BaseURL()
        {
            string baseurl = "https://v29.wpengine.com/eclipse-access/";
            WebElementExtensions.CheckURL(baseurl);
        }

        public static void LoginErrorTitle()
        {
            WebElementExtensions.FindElement("Id", "eclipse_access_title");
        }
    }
}
