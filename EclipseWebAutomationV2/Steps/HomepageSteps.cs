using AventStack.ExtentReports.Reporter;
using EclipseWebAutomationV2.Configurations;
using EclipseWebAutomationV2.PageObjects;
using System;
using TechTalk.SpecFlow;
using System.Configuration;
using TechTalk.SpecFlow.Assist;
using AventStack.ExtentReports;
using NUnit.Framework;
using AventStack.ExtentReports.Gherkin.Model;
using EclipseWebAutomationV2.PageObjects.Jobs;

namespace EclipseWebAutomationV2.Steps
{
    [Binding]
    public class HomepageSteps
    {
        [Given(@"The homepage has been navigated to")]
        public void GivenTheHomepageHasBeenNavigatedTo()
        {
            HomePage.BaseURL();
        }        
        
        [When(@"The homepage (.*) link is clicked")]
        public void WhenTheHomepageLinkIsClicked(string link)
        {
            if (link == "Login")
            {
                HomePage.LoginLink();
            }
            else
            {
                HomePage.JobBoardLink();
            }

        }

            [Then(@"The (.*) page is loaded")]
        public void ThenThePageIsLoaded(string link)
        {
            if (link == "Job Board")
            {
                JobBoardPage.BaseURL();
            }
            else
            {
                LoginPage.BaseURL();
            }
        }

    }

}
