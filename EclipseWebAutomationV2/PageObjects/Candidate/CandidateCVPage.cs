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
    class CandidateCVPage
    {
        public static string cvname = "JackCV.docx";

        public static void BaseURL()
        {
            string baseurl = "https://v29.wpengine.com/dashboard/cv/";
            WebElementExtensions.CheckURL(baseurl);
        }

        public static void AttachCV()
        {
            WebElementExtensions.FindElement("Id", "eclipse_recruitment_cv_file");
            IWebElement attachcv = Driver.WebDriver.FindElement(By.Id("eclipse_recruitment_cv_file"));
            attachcv.WeSendKeys($@"D:\temp\EclipseWebAutomationV2\{cvname}");
        }

        public static void UploadCV()
        {
            WebElementExtensions.FindElement("ClassName", "button");
            IWebElement uploadbutton = Driver.WebDriver.FindElement(By.ClassName("button"));
            uploadbutton.WeClick();
        }

        public static void CheckCVUpload()
        {
            WebElementExtensions.FindElement("LinkText", cvname);
        }

        public static void OpenCV()
        {
            WebElementExtensions.FindElement("LinkText", cvname);
            IWebElement opencv = Driver.WebDriver.FindElement(By.LinkText(cvname));
            opencv.WeClick();
        }

        public static void CheckCVDownload()
        {
            WebElementExtensions.FileIsDownloaded(cvname);
        }
    }
}
