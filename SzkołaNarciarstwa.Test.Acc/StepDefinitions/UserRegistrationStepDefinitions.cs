using System;
using SzkolaNarciarstwa;
using System.Windows.Forms;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SzkolaNarciarstwa.Test.Acc.StepDefinitions
{
    [Binding]
    public class UserRegistrationStepDefinitions
    {
        private Form mainForm;  //Skąd bierze dane 
        private RegisterForm registerForm;

        [Given(@"I am on the registration page")]
        public void GivenIAmOnTheRegistrationPage()
        {
            mainForm = new Form(); //Wejscei w pole rejestracji
            registerForm = new RegisterForm(mainForm);
            registerForm.Show();
        }

        [When(@"I fill in valid registration details")]
        public void WhenIFillInValidRegistrationDetails()
        {
            registerForm.TxtUsername.Text = "testuser"; // Dummy dane
            registerForm.TxtPassword1.Text = "password123";
            registerForm.TxtPassword2.Text = "password123";
            registerForm.TxtEmail.Text = "test@example.com";
        }

        [When(@"I click the ""([^""]*)"" button")]
        public void WhenIClickTheButton(string buttonName)
        {
            if (buttonName == "Register")
            {
                registerForm.BtnSubmit_Click(null, null); //Wywołanie Submit
            }
        }

        [Then(@"I should see a success message")]
        public void ThenIShouldSeeASuccessMessage()
        {
            Assert.That(registerForm.Visible == false, "Rejestracja nie powiodła się.");
        }
    }
}
