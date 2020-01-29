using EclipseWebAutomationV2.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EclipseWebAutomationV2.PageObjects.Candidate
{
    class CandidateChangePasswordPage
    {
        public static void BaseURL()
        {
            string baseurl = "https://v29.wpengine.com/login/change-password/";
            WebElementExtensions.CheckURL(baseurl);
        }
    }
}
