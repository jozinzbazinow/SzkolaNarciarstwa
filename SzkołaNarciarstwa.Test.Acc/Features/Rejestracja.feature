   Feature: User Registration
     As a user
     I want to register an account
     So that I can log in later

   Scenario: Successful Registration
     Given I am on the registration page
     When I fill in valid registration details
     And I click the "Register" button
     Then I should see a success message