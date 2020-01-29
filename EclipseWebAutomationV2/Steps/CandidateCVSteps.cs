using EclipseWebAutomationV2.PageObjects;
using EclipseWebAutomationV2.PageObjects.Candidate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace EclipseWebAutomationV2.Steps
{
    [Binding]
    class CandidateCVSteps
    {
        [Given(@"The CV page has been navigated to")]
        public void GivenTheCVPageHasBeenNavigatedTo()
        {
            CandidateDashboard.CVButton();
            CandidateCVPage.BaseURL();
        }

        [When(@"The CV is attached")]
        public void WhenTheCVIsAttached()
        {
            CandidateCVPage.AttachCV();
        }

        [When(@"The Upload CV button is clicked")]
        public void WhenTheUploadCVButtonIsClicked()
        {
            CandidateCVPage.UploadCV();
        }

        [Then(@"The CV is uploaded")]
        public void ThenTheCVIsUploaded()
        {
            CandidateCVPage.CheckCVUpload();
        }

        [When(@"The open CV button is clicked")]
        public void WhenTheOpenCVButtonIsClicked()
        {
            CandidateCVPage.OpenCV();
        }

        [Then(@"The CV is downloaded")]
        public void ThenTheCVIsDownloaded()
        {
            CandidateCVPage.CheckCVDownload();
        }
    }
}
