using AventStack.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;


namespace BankSystemTestProject.Hooks
{
    [Binding]
    public sealed class HooksIntialization
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        private static ExtentReports _extent;
        private static ExtentReports _feature;
        private static ExtentReports _scenario;
        //private static ExtentHtmlReporter htmlReporter;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            //var htmlReporter = new ExtentHtmlReporter("ExtentReport.html");
            _extent = new ExtentReports();
            //_extent.AttachReporter(htmlReporter);
            //CreateWebHostBuilder(args).Build().Run();

        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext context)
        {
            //_feature = _extent.CreateTest(context.FeatureInfo.Title);
        }

        [BeforeScenario]
        public static void BeforeScenario(ScenarioContext context)
        {
            //_scenario = _feature.CreateNode(context.ScenarioInfo.Title);
        }


        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
