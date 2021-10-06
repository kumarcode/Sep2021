using System;
using TechTalk.SpecFlow;

namespace September2021.StepDefinition
{
    [Binding]
    public class TMFeatureSteps
    {
        [Given(@"I logged into turn up portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I navigate to time and material page")]
        public void GivenINavigateToTimeAndMaterialPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I create time and material record")]
        public void WhenICreateTimeAndMaterialRecord()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
