Feature: HomePage
	I have to validate information of bovespa indicator
	with DI tax

Scenario: Validate information website Bovespa
	Given I opened website bovespa
	And I have get value of bovespa indicator
	And I have get value of DI Tax
	Then the result should be showed on console


Scenario: Validate "Acesso Rapido" on the bovespa website
	Given I opened website bovespa
	And I have to click on link to Acesso aos sistemas
	Then I validate webpage opened