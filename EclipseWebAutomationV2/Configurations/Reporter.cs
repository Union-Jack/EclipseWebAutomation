using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using BoDi;
using EclipseWebAutomationV2.Steps;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Configuration;

namespace EclipseWebAutomationV2.Configurations
{
    class Reporter
    {

        public static ExtentTest featureName;
        public static ExtentTest scenario;
        public static ExtentReports extent;
//      public static ExtentKlovReporter klov;
        public static string exeptionmessage;
        public static string path;

        public static void ReportInit()
        {
            var htmlreporter = new ExtentHtmlReporter(@"D:\temp\EclipseWebAutomationV2\report.html");
            htmlreporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            extent = new ExtentReports();
//          klov = new ExtentKlovReporter("Eclipse Web Automation",(TestContext.CurrentContext.Test.Name + " " + DateTime.Now.ToString()));
//          klov.InitMongoDbConnection("localhost",27017);
//          klov.InitKlovServerConnection("http://localhost");
//          extent.AttachReporter(htmlreporter, klov);
            extent.AttachReporter(htmlreporter);
        }

       
        public static void ReportFeature(FeatureContext featureContext)
        {
            featureName = extent.CreateTest<Feature>(featureContext.FeatureInfo.Title);
        }

        public static void ReportScenario(ScenarioContext scenarioContext)
        {
            scenario = featureName.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
        }

        public static void ReportStep(ScenarioContext scenarioContext)
        {
            var steptype = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
            PropertyInfo pinfo = typeof(ScenarioContext).GetProperty("ScenarioExecutionStatus", BindingFlags.Instance | BindingFlags.Public);
            MethodInfo getter = pinfo.GetGetMethod(nonPublic: true);
            object testresults = getter.Invoke(scenarioContext, null);
            string[] tag = scenarioContext.ScenarioInfo.Tags;

            if (scenarioContext.TestError == null)
            {
                if (steptype == "Given")
                {
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).AssignCategory(tag);
                }
                else if (steptype == "When")
                {
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).AssignCategory(tag);

                }
                else if (steptype == "Then")
                {
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).AssignCategory(tag);

                }
                else if (steptype == "And")
                {
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).AssignCategory(tag);

                }
            }
            else
            {
                if (steptype == "Given")
                {
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).AssignCategory(tag).Fail(exeptionmessage, MediaEntityBuilder.CreateScreenCaptureFromPath(path).Build());
                }
                else if (steptype == "When")
                {
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).AssignCategory(tag).Fail(exeptionmessage, MediaEntityBuilder.CreateScreenCaptureFromPath(path).Build());
                }
                else if (steptype == "Then")
                {
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).AssignCategory(tag).Fail(exeptionmessage, MediaEntityBuilder.CreateScreenCaptureFromPath(path).Build());
                }
                else if (steptype == "And")
                {
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).AssignCategory(tag).Fail(exeptionmessage, MediaEntityBuilder.CreateScreenCaptureFromPath(path).Build());
                }
            }

            if (testresults.ToString() == "StepDefinitionPending")
            {
                if (steptype == "Given")
                {
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).AssignCategory(tag).Skip("Step Definition pending");
                }
                else if (steptype == "When")
                {
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).AssignCategory(tag).Skip("Step Definition pending");

                }
                else if (steptype == "Then")
                {
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).AssignCategory(tag).Skip("Step Definition pending");
                }
                else if (steptype == "And")
                {
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).AssignCategory(tag).Skip("Step Definition pending");

                }
            }
        }
        public static void ReportFlush()
        {
            extent.Flush();
        }
    }
}
