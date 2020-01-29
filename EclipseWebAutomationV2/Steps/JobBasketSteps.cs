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
    class JobBasketSteps
    {
        [Given(@"The job basket page has been navigated to")]
        public void GivenTheJobBasketPageHasBeenNavigatedTo()
        {
            CandidateDashboard.JobBasketButton();
            JobBasketPage.BaseURL();
        }

        [When(@"The remove button is clicked")]
        public void WhenTheRemoveButtonIsClicked()
        {
            JobBasketPage.RemoveFromBasketButton();
        }

        [Then(@"The item is deleted")]
        public void ThenTheItemIsDeleted()
        {
            JobBasketPage.JobSearchIsDeleted();
        }

    }
}
