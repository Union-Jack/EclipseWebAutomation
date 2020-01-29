using EclipseWebAutomationV2.Configurations;
using EclipseWebAutomationV2.PageObjects;
using EclipseWebAutomationV2.PageObjects.Candidate;
using EclipseWebAutomationV2.PageObjects.Client;
using System;
using TechTalk.SpecFlow;

namespace EclipseWebAutomationV2
{
    [Binding]
    public class LoginPageSteps
    {
        [Given(@"The login page has been navigated to")]
        public void GivenTheLoginPageHasBeenNavigatedTo()
        {
            HomePage.BaseURL();
            HomePage.LoginLink();
            LoginPage.BaseURL();
        }

        [When(@"The (.*), (.*) and (.*) are entered")]
        public void WhenTheAndAreEntered(string username, string password, string accounttype)
        {
            LoginPage.LoginFields(username, password, accounttype);
        }

        [When(@"The login button is clicked")]
        public void WhenTheLoginButtonIsClicked()
        {
            LoginPage.LoginButton();
        }

        [Then(@"The access page is displayed")]
        public void ThenTheAccessPageIsDisplayed()
        {
            AccessPage.BaseURL();
        }

        [Then(@"The candidate dashboard is loaded")]
        public void ThenTheCandidateDashboardIsLoaded()
        {
            CandidateDashboard.BaseURL();
        }

        [Then(@"The client dashboard is loaded")]
        public void ThenTheClientDashboardIsLoaded()
        {
            ClientDashboard.BaseURL();
        }

        [Then(@"The login error is displayed")]
        public void ThenTheLoginErrorIsDisplayed()
        {
            AccessPage.LoginErrorTitle();
        }

    }
}
