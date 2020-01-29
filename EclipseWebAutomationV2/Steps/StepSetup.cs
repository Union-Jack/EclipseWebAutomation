using BoDi;
using EclipseWebAutomationV2.Configurations;
using EclipseWebAutomationV2.PageObjects;
using EclipseWebAutomationV2.PageObjects.Candidate;
using EclipseWebAutomationV2.PageObjects.Client;
using EclipseWebAutomationV2.PageObjects.Jobs;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Configuration;

namespace EclipseWebAutomationV2.Steps
{
    [Binding]

    class StepSetup
    {

        [BeforeTestRun]
        public static void InitializeReport()
        {
            Reporter.ReportInit();
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            Reporter.ReportFeature(featureContext);
        }

        [BeforeScenario("Chrome")]
        public void BeforeChrome(ScenarioContext scenarioContext)
        {
            Reporter.ReportScenario(scenarioContext);
            string Browser = "Chrome";
            Driver.Init(Browser);

        }

        [BeforeScenario("Firefox")]
        public void BeforeFirefox(ScenarioContext scenarioContext)
        {

            Reporter.ReportScenario(scenarioContext);
            string Browser = "Firefox";
            Driver.Init(Browser);

        }

        [AfterStep]
        public void InsertReportingSteps(ScenarioContext scenarioContext)
        {
            Reporter.ReportStep(scenarioContext);
        }

        [AfterScenario]
        public static void AfterMethod()
        {
            Reporter.ReportFlush();
            Driver.Close();
        }


        [Given(@"The user is (.*)")]
        public void GivenTheUserIs(string login)
        {
            HomePage.BaseURL();
            if (login == "logged in as a candidate")
            {
                HomePage.LoginLink();
                LoginPage.BaseURL();
                LoginPage.LoginFields("liamknowles", "liamknowles", "candidate");
                LoginPage.LoginButton();
                CandidateDashboard.BaseURL();
            }
            else if (login == "logged in as a client")
            {
                HomePage.LoginLink();
                LoginPage.BaseURL();
                LoginPage.LoginFields("tickleclient@eclipse-software.co.uk", "12345", "client");
                LoginPage.LoginButton();
                ClientDashboard.BaseURL();
            }
            else
            {
                HomePage.JobBoardLink();
                JobBoardPage.BaseURL();
            }
        }

    }
}
