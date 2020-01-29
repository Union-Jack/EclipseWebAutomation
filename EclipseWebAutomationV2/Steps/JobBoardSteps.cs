using EclipseWebAutomationV2.PageObjects;
using EclipseWebAutomationV2.PageObjects.Candidate;
using EclipseWebAutomationV2.PageObjects.Jobs;
using TechTalk.SpecFlow;

namespace EclipseWebAutomationV2.Steps
{
    [Binding]
    class JobBoardSteps
    {
        [Given(@"The jobs board is navigated to")]
        public void GivenTheJobsBoardIsNavigatedTo()
        {
            CandidateDashboard.JobsButton();
            JobBoardPage.BaseURL();
        }

        [Given(@"The job posting on the (.*) page has been navigated to")]
        public void GivenTheJobPostingOnThePageHasBeenNavigatedTo(string page)
        {
            if (page == "candidate job board")
            {
                CandidateDashboard.JobsButton();
            }
            else if (page == "candidate more details")
            {
                CandidateDashboard.JobsButton();
                JobBoardPage.MoreDetails();
            }
            else if (page == "more details")
            {
                JobBoardPage.MoreDetails();
            }
        }
    }
}