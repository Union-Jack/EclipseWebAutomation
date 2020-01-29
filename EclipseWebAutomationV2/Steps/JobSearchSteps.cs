using EclipseWebAutomationV2.PageObjects;
using EclipseWebAutomationV2.PageObjects.Candidate;
using EclipseWebAutomationV2.PageObjects.Client;
using EclipseWebAutomationV2.PageObjects.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace EclipseWebAutomationV2.Steps
{
    [Binding]
    public sealed class JobSearchSteps
    {
        [When(@"I enter (.*) into the keywords field")]
        public void WhenIEnterIntoTheKeywordsField(string keyword)
        {
            MultiplePages.Keyword(keyword);
        }

        [When(@"I select a (.*) into the country field")]
        public void WhenISelectAIntoTheCountryField(string country)
        {
            MultiplePages.Country(country);
        }

        [When(@"I select a (.*) into the region field")]
        public void WhenISelectAIntoTheRegionField(string region)
        {
            MultiplePages.Region(region);
        }

        [When(@"I select a (.*) into the location field")]
        public void WhenISelectAIntoTheLocationField(string location)
        {
            MultiplePages.Location(location);
        }

        [When(@"I select a (.*) into the industry field")]
        public void WhenISelectAIntoTheIndustryField(string industry)
        {
            MultiplePages.Industry(industry);
        }

        [When(@"I select a (.*) into the discipline field")]
        public void WhenISelectAIntoTheDisciplineField(string discipline)
        {
            MultiplePages.Discipline(discipline);
        }

        [When(@"I click go")]
        public void WhenIClickGo()
        {
            MultiplePages.GoButton();
        }

        [Then(@"The jobs board is loaded")]
        public void ThenTheJobsBoardIsLoaded()
        {
            JobBoardPage.BaseURL();
        }

    }
}
