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
    class JobSearchesSteps
    {
        [Given(@"The job searches page has been navigated to")]
        public void GivenTheJobSearchesPageHasBeenNavigatedTo()
        {
            CandidateDashboard.JobSearchesButton();
            JobSearchesPage.BaseURL();
        }

        [When(@"The search jobs button is clicked")]
        public void WhenTheSearchJobsButtonIsClicked()
        {
            JobSearchesPage.SearchJobsButton();
        }

        [Then(@"The jobs are searched for")]
        public void ThenTheJobsAreSearchedFor()
        {
            JobBoardPage.BaseURL();
        }

        [When(@"The delete button is clicked")]
        public void WhenTheDeleteButtonIsClicked()
        {
            JobSearchesPage.DeleteSearchJobsButton();
        }

        [Then(@"The job search is deleted")]
        public void ThenTheJobSearchIsDeleted()
        {
            JobSearchesPage.JobSearchIsDeleted();
        }


    }
}
