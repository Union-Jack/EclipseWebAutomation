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
    class CandidateDashboardSteps
    {



        [When(@"The (.*) dashboard button is clicked")]
        public void WhenTheDashboardButtonIsClicked(string page)
        {
            if (page == "Profile")
            {
                CandidateDashboard.ProfileButton();
            }
            else if (page == "CV")
            {
                CandidateDashboard.CVButton();
            }
            else if (page == "Timesheets")
            {
                CandidateDashboard.TimesheetsButton();
            }
            else if (page == "Job Searches")
            {
                CandidateDashboard.JobSearchesButton();
            }
            else if (page == "Job Basket")
            {
                CandidateDashboard.JobBasketButton();
            }
            else if (page == "Job Applications")
            {
                CandidateDashboard.JobApplicationsButton();
            }
            else if (page == "Change Password")
            {
                CandidateDashboard.ChangePasswordButton();
            }
            else if (page == "Jobs Board")
            {
                CandidateDashboard.JobsButton();
            }
        }

        [Then(@"The candidate (.*) page is opened")]
        public void ThenTheCandidatePageIsOpened(string page)
        {
            if (page == "Profile")
            {
                CandidateProfilePage.BaseURL();
            }
            else if (page == "CV")
            {
                CandidateCVPage.BaseURL();
            }
            else if (page == "Timesheets")
            {
                CandidateTimesheetsPage.BaseURL();
            }
            else if (page == "Job Searches")
            {
                JobSearchesPage.BaseURL();
            }
            else if (page == "Job Basket")
            {
                JobBasketPage.BaseURL();
            }
            else if (page == "Job Applications")
            {
                JobApplicationsPage.BaseURL();
            }
            else if (page == "Change Password")
            {
                CandidateChangePasswordPage.BaseURL();
            }
            else if (page == "Jobs Board")
            {
                JobBoardPage.BaseURL();
            }
        }
    }
}
