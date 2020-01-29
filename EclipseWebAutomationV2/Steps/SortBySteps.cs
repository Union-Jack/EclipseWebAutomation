using EclipseWebAutomationV2.PageObjects;
using EclipseWebAutomationV2.PageObjects.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace EclipseWebAutomationV2.Steps
{
    [Binding]
    class SortBySteps
    {


        [When(@"The job board is sorted by (.*)")]
        public void WhenTheJobBoardIsSortedBy(string sorting)
        {
            if (sorting == "StartDate")
            {
                JobBoardPage.SortByStartDate();
            }
        }

        [Then(@"The jobs are sorted by (.*) order")]
        public void ThenTheJobsAreSortedByOrder(string sorting)
        {
            if (sorting == "StartDate")
            {
                JobBoardPage.CheckStartDate();
            }
            else
            {
                JobBoardPage.SortByLatest();
            }
        }



    }
}
