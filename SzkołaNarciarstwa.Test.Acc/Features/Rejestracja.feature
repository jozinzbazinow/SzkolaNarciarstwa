   Feature: User Registration
     Jako uzytkownik chce zalozyc konto
     aby potem sie zalogowac
@tag1
   Scenario: Successful Registration
     Given I am on the registration page
     When I fill in valid registration details
     And I click the "Register" button
     Then I should see a success message