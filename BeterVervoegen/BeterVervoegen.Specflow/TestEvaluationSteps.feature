Feature: TestEvaluation
	In order to improve my knowledge of verbs
	As a language learner
	I want to be told how many verbs i have conjugated correctly

@mytag
Scenario: evaluate the answer to a question
	Given the infinitive is 'zijn', the simple past is 'was' and the past participle is 'geweest'
	And I have entered 'was' as simple past
	And I have entered 'geweest' as past participle
	When the question is evaluated
	Then the result should be 'ok' on the screen

