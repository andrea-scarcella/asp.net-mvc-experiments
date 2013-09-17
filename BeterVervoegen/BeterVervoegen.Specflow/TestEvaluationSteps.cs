using System;
using BeterVervoegen.BL;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
namespace BeterVervoegen.Specflow
{
	[Binding]
	public class TestEvaluationSteps
	{
		#region Scenario 1

		[Given(@"the infinitive is '(.*)', the simple past is '(.*)' and the past participle is '(.*)'")]
		public void GivenTheInfinitiveIsTheSimplePastIsAndThePastParticipleIs(string p0, string p1, string p2)
		{
			var question = new TestItem(Infinitive: p0, SimplePast: p1, PastParticiple: p2);

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
			testItem.Evaluate();

		}



		[Then(@"the result should be '(.*)' on the screen")]
		public void ThenTheResultShouldBeOnTheScreen(string p0)
		{
			var testItem = ScenarioContext.Current.Get<TestItem>(testItemKey);
			Assert.AreEqual("OK", testItem.Result());

		}

		public string testItemKey = "Question";
		#endregion

		#region Scenario 2
		[Given(@"there is a test with the following test items")]
		public void GivenThereIsATestWithTheFollowingTestItems(Table table)
		{
			var itemList = table.CreateSet<TestItem>();
			var test = new Test(itemList);
			ScenarioContext.Current.Add(testKey, test);

			
		}

		[Given(@"I have chosen '(.*)' as simple past for item '(.*)'")]
		public void GivenIHaveChosenAsSimplePastForItem(string p0, int p1)
		{
			var test = ScenarioContext.Current.Get<Test>(testKey);
			test.Item(p1).AnswerSimplePast = p0;
		}

		[Given(@"I have chosen '(.*)' as past participle for item '(.*)'")]
		public void GivenIHaveChosenAsPastParticipleForItem(string p0, int p1)
		{
			var test = ScenarioContext.Current.Get<Test>(testKey);
			test.Item(p1).AnswerPastParticiple = p0;

		}

		[When(@"the test is evaluated")]
		public void WhenTheTestIsEvaluated()
		{
			var test = ScenarioContext.Current.Get<Test>(testKey);
			test.Evaluate();
		}

		[Then(@"the test result should be '(.*)' on the screen")]
		public void ThenTheTestResultShouldBeOnTheScreen(string p0)
		{
			var test = ScenarioContext.Current.Get<Test>(testKey);

			Assert.AreEqual(p0, test.Result());
		}

		#endregion

		[Then(@"the test score should be '(.*)'")]
		public void ThenTheTestScoreShouldBe(Decimal p0)
		{
			var test = ScenarioContext.Current.Get<Test>(testKey);
			Assert.AreEqual(p0, test.Score());
		}


		public string testKey = "testKey";
	}
}
