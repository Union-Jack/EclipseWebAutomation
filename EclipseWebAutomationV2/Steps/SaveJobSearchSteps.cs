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
    class SaveJobSearchSteps
    {
        
        [Given(@"The job criteria has been searched for")]
        public void GivenTheJobCriteriaHasBeenSearchedFor()
        {
            MultiplePages.Keyword("Surgeon");
//            MultiplePages.Country("United Kingdom");
//            MultiplePages.Region("Greater Manchester");
//            MultiplePages.Location("Manchester");
//            MultiplePages.Industry("Medical");
//            MultiplePages.Discipline("Surgeon");
            MultiplePages.GoButton();
            JobBoardPage.BaseURL();
        }

        [Then(@"The job searches page is displayed")]
        public void ThenTheJobSearchesPageIsDisplayed()
        {
            JobSearchesPage.BaseURL();
        }


        [When(@"The save search button is clicked")]
        public void WhenTheSaveSearchButtonIsClicked()
        {
            JobBoardPage.SaveSearch();
        }

        [Then(@"The save jobs search page is displayed")]
        public void ThenTheSaveJobsSearchPageIsDisplayed()
        {
            SaveJobSearchPage.BaseURL();
        }


        [Then(@"A name is entered")]
        public void ThenANameIsEntered()
        {
            SaveJobSearchPage.SearchName("Surgeon");
        }

        [Then(@"The save button is clicked")]
        public void ThenTheSaveButtonIsClicked()
        {
            SaveJobSearchPage.SaveButton();
        }

        [Then(@"The job search will be saved")]
        public void ThenTheJobSearchWillBeSaved()
        {
            JobSearchesPage.CheckForSearch("Surgeon");
        }

        [Then(@"The user is asked to log in as a candidate")]
        public void ThenTheUserIsAskedToLogInAsACandidate()
        {
            SaveJobSearchPage.LogoutButton();
        }

    }
}
