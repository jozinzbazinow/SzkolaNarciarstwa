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
        private PanelUzytkownika panelUzytkownika;

        [Given("Jestem na stronie logowania")]
        public void GivenJestemNaStronieLogowania()
        {
            mainForm = new Form();
            loginForm = new LoginForm(mainForm, 1);
            panelUzytkownika = new PanelUzytkownika(mainForm);
            loginForm.Show();
        }

        [When("Wypelnie poprawnie formularz")]
        public void WhenWypelniePoprawnieFormularz()
        {
            loginForm.TxtUsernameL.Text = "testuser";
            loginForm.TxtPasswordL.Text = "password123";
        }

        [When("Nacisne przycisk \"([^\"]*)\" sie")]
        public void WhenNacisnePrzyciskZalogujSie(string buttonName)
        {
            if (buttonName == "zaloguj")
            {
                loginForm.BtnSubmit_Click(null, null); //Wywo³anie Submit
            }
        }

        [Then("Udalo mi sie zalogowac")]
        public void ThenUdaloMiSieZalogowac()
        {
            Assert.That(panelUzytkownika.Visible == false, "Logowanie nie powiod³o siê");
        }
    }
}
