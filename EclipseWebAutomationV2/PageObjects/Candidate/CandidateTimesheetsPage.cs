using EclipseWebAutomationV2.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EclipseWebAutomationV2.PageObjects.Candidate
{
    class CandidateTimesheetsPage
    {
        public static void BaseURL()
        {
            string baseurl = "https://v29.wpengine.com/dashboard/timesheets/";
            WebElementExtensions.CheckURL(baseurl);
        }
    }
}
