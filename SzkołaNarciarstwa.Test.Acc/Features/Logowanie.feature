Feature: Logowanie

A short summary of the feature

@tag2
Scenario: Udane Logowanie
	Given Jestem na stronie logowania
	When Wypelnie poprawnie formularz
	And Nacisne przycisk "zaloguj" sie
	Then Udalo mi sie zalogowac
