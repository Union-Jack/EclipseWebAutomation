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
    class AddToBasketSteps
    {
        [When(@"The add to basket button is clicked")]
        public void WhenTheAddToBasketButtonIsClicked()
        {
            JobBoardPage.AddToBasket();
        }

        [Then(@"The job is added to the basket")]
        public void ThenTheJobIsAddedToTheBasket()
        {
            JobBoardPage.AddedToBasket();
        }

    }
}
