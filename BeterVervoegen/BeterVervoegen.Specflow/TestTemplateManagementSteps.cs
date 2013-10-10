using System;
using BeterVervoegen.BL;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BeterVervoegen.Specflow
{
	[Binding]
	public class TestTemplateManagementSteps
	{
		private const string VerbsKey = "verbsKey";

		[Given(@"I have chosen the following verbs")]
		public void GivenIHaveChosenTheFollowingVerbs(Table table)
		{
			var verbList = table.CreateSet<Verb>();
			ScenarioContext.Current.Add(VerbsKey, verbList);

		}

		[Given(@"I have chosen '(.*)' as a test template")]
		public void GivenIHaveChosenAsATestTemplate(string p0)
		{
			ScenarioContext.Current.Pending();//enum?
		}

		[When(@"I press new template")]
		public void WhenIPressNewTemplate()
		{
			ScenarioContext.Current.Pending();//factory, params (type, verbs)
		}

		[Then(@"a new template should be created")]
		public void ThenANewTemplateShouldBeCreated()
		{
			ScenarioContext.Current.Pending();//try and retrieve template?
		}
	}

	public class Verb
	{
	}
}
