using EclipseWebAutomationV2.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EclipseWebAutomationV2.PageObjects.Client
{
    class ClientDashboard
    {
        public static void BaseURL()
        {
            string baseurl = "https://v29.wpengine.com/cli-dashboard/";
            WebElementExtensions.CheckURL(baseurl);
        }
    }
}
