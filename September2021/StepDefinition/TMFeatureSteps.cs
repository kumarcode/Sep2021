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

        // page object init
        TMPage tmPageObj = new TMPage();
        HomePage homePageObj = new HomePage();
        LoginPage loginPageObj = new LoginPage();



        [Given(@"I logged into turn up portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            // open chrome browser
            driver = new ChromeDriver();

            // Login page object initialization and definition
            loginPageObj.LoginActions(driver);
        }

        [Given(@"I navigate to time and material page")]
        public void GivenINavigateToTimeAndMaterialPage()
        {
            // Home page object initialization and definition
            homePageObj.GoToTMPage(driver);
        }
        
        [When(@"I create time and material record")]
        public void WhenICreateTimeAndMaterialRecord()
        {
            // TM page object initialization and definition
            tmPageObj.CreateTM(driver);
        }
        
        [Then(@"the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            string newCode = tmPageObj.GetCode(driver);
            string newTypeCode = tmPageObj.GetTypeCode(driver);

            Assert.That(newCode == "September2021", "Code did not match");
            Assert.That(newTypeCode == "T", "Type Code did not match");
        }
        [When(@"I update '(.*)' '(.*)' on an existing time and material record")]
        public void WhenIUpdateOnAnExistingTimeAndMaterialRecord(string p0, string p1)
        {
            tmPageObj.EditTM(driver, p0, p1);
        }


        [Then(@"the record should have the updated '(.*)'")]
        public void ThenTheRecordShouldHaveTheUpdated(string p0)
        {
            Assert.That(tmPageObj.GetDescription(driver) == p0, "Descriptions don't match");
                
        }



    }
}
