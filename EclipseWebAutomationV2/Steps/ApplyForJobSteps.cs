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
    class ApplyForJobSteps
    {
        [When(@"The apply button is clicked")]
        public void WhenTheApplyButtonIsClicked()
        {
            JobBasketPage.ApplyButton();
        }

        [Then(@"The job is applied for")]
        public void ThenTheJobIsAppliedFor()
        {
            JobApplicationsPage.BaseURL();

        }

    }
}