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
    class RequestDetailsSteps
    {

        [When(@"The request details button is clicked")]
        public void WhenTheRequestDetailsButtonIsClicked()
        {
            JobBoardPage.RequestDetails();
        }


        [When(@"The name (.*) is entered into the name field")]
        public void WhenTheNameIsEnteredIntoTheNameField(string name)
        {
            JobBoardPage.YourNameField(name);
        }

        [When(@"The email (.*) is enterd into the email field")]
        public void WhenTheEmailIsEnterdIntoTheEmailField(string email)
        {
            JobBoardPage.YourEmailField(email);
        }

        [When(@"The subject (.*) is entered into the subject field")]
        public void WhenTheSubjectIsEnteredIntoTheSubjectField(string subject)
        {
            JobBoardPage.SubjectField(subject);
        }

        [When(@"The message (.*) is entered into the message field")]
        public void WhenTheMessageIsEnteredIntoTheMessageField(string message)
        {
            JobBoardPage.YourMessageField(message);
        }

        [When(@"The send button is clicked")]
        public void WhenTheSendButtonIsClicked()
        {
            JobBoardPage.SendButton();
        }

        [Then(@"The request is sent")]
        public void ThenTheRequestIsSent()
        {
            JobBoardPage.RequestWasSent();
        }
    }
}