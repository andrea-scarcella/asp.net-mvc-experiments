using System;
using TechTalk.SpecFlow;

namespace BeterVervoegen.Specflow
{
    [Binding]
    public class TestEvaluationSteps
    {
        [Given(@"the infinitive is '(.*)'")]
        public void GivenTheInfinitiveIs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered '(.*)' as simple past")]
        public void GivenIHaveEnteredAsSimplePast(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered '(.*)' as past participle")]
        public void GivenIHaveEnteredAsPastParticiple(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press submit")]
        public void WhenIPressSubmit()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be '(.*)' on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
