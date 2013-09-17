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
	Then the result should be 'OK' on the screen

Scenario: evaluate a test
	Given there is a test with the following test items
	| ItemID | Infinitive | SimplePast | PastParticiple |
	| 1      | zijn       | was        | geweest        |
	| 2      | lopen      | liep       | gelopen        |
	| 3      | eten       | at         | gegeten        |
	And I have chosen 'was' as simple past for item '1'
	And I have chosen 'geweest' as past participle for item '1'

	And I have chosen 'liep' as simple past for item '2'
	And I have chosen 'gelopen' as past participle for item '2'

	And I have chosen 'at' as simple past for item '3'
	And I have chosen 'gegeten' as past participle for item '3'
	When the test is evaluated
	Then the test result should be 'OK' on the screen
	 

	 Scenario: evaluate a test with mistakes
	Given there is a test with the following test items
	| ItemID | Infinitive | SimplePast | PastParticiple |
	| 1      | zijn       | was        | geweest        |
	| 2      | lopen      | liep       | gelopen        |
	| 3      | eten       | at         | gegeten        |
	And I have chosen 'xxx' as simple past for item '1'
	And I have chosen 'yyy' as past participle for item '1'

	And I have chosen 'liep' as simple past for item '2'
	And I have chosen 'gelopen' as past participle for item '2'

	And I have chosen 'zzz' as simple past for item '3'
	And I have chosen 'gegeten' as past participle for item '3'
	When the test is evaluated
	Then the test result should be 'KO' on the screen
	 


	 Scenario: evaluate a test with mistakes and compute its score
	Given there is a test with the following test items
	| ItemID | Infinitive | SimplePast | PastParticiple |
	| 1      | zijn       | was        | geweest        |
	| 2      | lopen      | liep       | gelopen        |
	| 3      | eten       | at         | gegeten        |
	And I have chosen 'xxx' as simple past for item '1'
	And I have chosen 'yyy' as past participle for item '1'

	And I have chosen 'liep' as simple past for item '2'
	And I have chosen 'gelopen' as past participle for item '2'

	And I have chosen 'at' as simple past for item '3'
	And I have chosen 'gegeten' as past participle for item '3'
	When the test is evaluated
	Then the test result should be 'KO' on the screen 
	And the test score should be '66'
	#And the correct simple past of item '1' should be 'was' 
	#And the correct past participle of item '1' should be 'geweest' 
	#And the correct simple past of item '2' should be 'liep' 
	#And the correct past participle of item '2' should be 'gelopen' 
	#And the correct simple past of item '3' should be 'at' 
	#And the correct past participle of item '3' should be 'gegeten' 