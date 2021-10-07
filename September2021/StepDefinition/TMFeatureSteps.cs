using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using September2021.Pages;
using September2021.Utilities;
using System;
using TechTalk.SpecFlow;

namespace September2021.StepDefinition
{
    [Binding]
    public class TMFeatureSteps : CommonDriver
    {
        [Given(@"I logged into turn up portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            // open chrome browser
            driver = new ChromeDriver();

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);
        }

        [Given(@"I navigate to time and material page")]
        public void GivenINavigateToTimeAndMaterialPage()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);
        }
        
        [When(@"I create time and material record")]
        public void WhenICreateTimeAndMaterialRecord()
        {
            // TM page object initialization and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);
        }
        
        [Then(@"the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            TMPage tmPageObj = new TMPage();

            string newCode = tmPageObj.GetCode(driver);
            string newTypeCode = tmPageObj.GetTypeCode(driver);

            Assert.That(newCode == "September2021", "Code did not match");
            Assert.That(newTypeCode == "T", "Type Code did not match");
        }

        [When(@"I update '(.*)' on an existing time and material record")]
        public void WhenIUpdateOnAnExistingTimeAndMaterialRecord(string p0)
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTM(driver, p0);
        }

        [Then(@"the record should have the updated '(.*)'")]
        public void ThenTheRecordShouldHaveTheUpdated(string p0)
        {
            TMPage tmPageObj = new TMPage();
            Assert.That(tmPageObj.GetDescription(driver) == p0, "Descriptions don't match");
                
        }



    }
}
