Feature: UsunKonto

Jako użytkownik chcę usunąć konto uczen

@tag3
Scenario: Usuniecie Konta Ucznia
	Given Zalogowany jako uczen oraz w panelu potwierdzenie usuniecia konta
	When Potwierdzam haslo przyciskiem
	Then udalo mi sie usunac konto
