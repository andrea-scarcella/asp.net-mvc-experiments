using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BeterVervoegen.Specflow
{
	[Binding]
	public class TestEvaluationSteps
	{
		[Given(@"the infinitive is '(.*)', the simple past is '(.*)' and the past participle is '(.*)'")]
		public void GivenTheInfinitiveIsTheSimplePastIsAndThePastParticipleIs(string p0, string p1, string p2)
		{
			var question = new TestItem(infinitive: p0, simplePast: p1, pastParticiple: p2);

			ScenarioContext.Current.Add(testItemKey, question);
		}


		
		[Given(@"I have entered '(.*)' as simple past")]
		public void GivenIHaveEnteredAsSimplePast(string p0)
		{
			var testItem = ScenarioContext.Current.Get<TestItem>(testItemKey);
			testItem.AnswerSimplePast = p0;

		}

		[Given(@"I have entered '(.*)' as past participle")]
		public void GivenIHaveEnteredAsPastParticiple(string p0)
		{
			var testItem = ScenarioContext.Current.Get<TestItem>(testItemKey);
			testItem.AnswerPastParticiple = p0;

		}

		[When(@"the question is evaluated")]
		public void WhenTheQuestionIsEvaluated()
		{
			var testItem = ScenarioContext.Current.Get<TestItem>(testItemKey);
			testItem.evaluate();

		}



		[Then(@"the result should be '(.*)' on the screen")]
		public void ThenTheResultShouldBeOnTheScreen(string p0)
		{
			var testItem = ScenarioContext.Current.Get<TestItem>(testItemKey);
			Assert.AreEqual("OK", testItem.Result());

		}

		public string testItemKey = "Question";
	}
}
