using System;
using System.Windows.Forms;
using NUnit.Framework;
using SpecFlow;

namespace SzkolaNarciarstwa.Test.Acc.StepDefinitions
{
    [Binding]
    public class LogowanieStepDefinitions
    {
        private Form mainForm;
        private LoginForm loginForm;

        [Given("Jestem na stronie logowania")]
        public void GivenJestemNaStronieLogowania()
        {
            mainForm = new Form();
            loginForm = new LoginForm(mainForm, 1);
            loginForm.Show();
        }

        [When("Wypelnie poprawnie formularz")]
        public void WhenWypelniePoprawnieFormularz()
        {
            try
            {
                loginForm.TxtUsername.Text += "testuser";
                loginForm.TxtPassword.Text += "password123";
            }
            catch (Exception ex)
            {
                // Handle exception or log it
                Console.WriteLine(ex.Message);
            }
        }

        [When("Nacisne przycisk \"([^\"]*)\" sie")]
        public void WhenNacisnePrzyciskZalogujSie(string buttonName) //Error drag and drop, nie zmienia nic 
        {
            if (buttonName == "zaloguj")
            {
                loginForm.BtnSubmit_Click(null, null); //Wywo³anie Submit
            }
        }

        [Then("Udalo mi sie zalogowac")]
        public void ThenUdaloMiSieZalogowac()
        {
            Assert.That(loginForm.Visible == false, "Logowanie nie powiod³o siê");
        }
    }
}
