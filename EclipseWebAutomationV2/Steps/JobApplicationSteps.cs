using EclipseWebAutomationV2.PageObjects;
using EclipseWebAutomationV2.PageObjects.Candidate;
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
    class JobApplicationSteps
    {
        [Given(@"The job applications has been navigated to")]
        public void GivenTheJobApplicationsHasBeenNavigatedTo()
        {

            CandidateDashboard.JobApplicationsButton();
            JobApplicationsPage.BaseURL();
        }

        [When(@"The delete application button is clicked")]
        public void WhenTheDeleteApplicationButtonIsClicked()
        {
            JobApplicationsPage.DeleteApplication();
        }

        [Then(@"The job application is deleted")]
        public void ThenTheJobApplicationIsDeleted()
        {
            JobApplicationsPage.DeleteApplicationCheck();
        }

    }
}
