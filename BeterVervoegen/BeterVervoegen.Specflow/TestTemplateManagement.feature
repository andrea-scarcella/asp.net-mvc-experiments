Feature: TestTemplateManagement
	In order to speedup the test creation process
	As a content producer
	I want to generate  a template from verbs and a template type

@mytag
Scenario: create  template from verbs and type
	Given I have chosen the following verbs
	| Infinitive | SimplePast | PastParticiple |
	| zijn       | was        | geweest        |
	| lopen      | liep       | gelopen        |
	And I have chosen 'FreeTextItems' as a test template

	#And I have entered 70 into the calculator
	When I press new template
	Then a new template should be created
