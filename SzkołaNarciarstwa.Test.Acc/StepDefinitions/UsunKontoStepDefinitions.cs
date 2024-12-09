using System;
using System.Windows.Forms;
using NUnit.Framework;
using SpecFlow;

namespace SzkolaNarciarstwa.Test.Acc.StepDefinitions
{
    [Binding]
    public class UsunKontoStepDefinitions
    {
        private Form mainForm;
        private Form loginForm;
        private PotwierdzenieUsunieciaKonta potwierdzenieUsunieciaKonta;

        [Given("Zalogowany jako uczen oraz w panelu potwierdzenie usuniecia konta")]
        public void GivenZalogowanyJakoUczenOrazWPaneluPotwierdzenieUsunieciaKonta()
        {
            mainForm = new Form();
            loginForm = new LoginForm(mainForm, 1);
            potwierdzenieUsunieciaKonta = new PotwierdzenieUsunieciaKonta(loginForm);

        }

        [When("Potwierdzam haslo przyciskiem")]
        public void WhenPotwierdzamHasloPrzyciskiem()
        {
            potwierdzenieUsunieciaKonta.TxtPassword.Text = "password123";
            if (true)
            {
            potwierdzenieUsunieciaKonta.BtnPotwierdz_Click(null, null);
            }
        }

        [Then("udalo mi sie usunac konto")]
        public void ThenUdaloMiSieUsunacKonto()
        {
            Assert.That(potwierdzenieUsunieciaKonta.Visible == false);
        }
    }
}
