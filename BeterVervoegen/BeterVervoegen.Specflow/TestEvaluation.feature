Feature: TestEvaluation
	In order to improve my knowledge of verbs
	As a language learner
	I want to be told how many verbs i have conjugated correctly

@mytag
Scenario: evaluate the answer to a question
	Given the infinitive is 'zijn'
	And I have entered 'was' as simple past
	And I have entered 'geweest' as past participle
	When I press submit
	Then the result should be 'ok' on the screen

