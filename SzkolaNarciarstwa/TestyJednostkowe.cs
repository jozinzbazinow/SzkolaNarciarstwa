using NUnit.Framework;
using Moq;
using SzkolaNarciarstwa;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MySqlX.XDevAPI.Common;

namespace SzkolaNarciarstwa.Tests
{
    [TestFixture]
    public class TestyJednostkowe
    {
        [SetUp]
        public void Setup() { 
        
        }

        [Test]
        public void LoginTest()
        {
            var loginForm = new LoginForm(new Mock<Form>().Object, 1);
            string login = "user";
            string password = "user";
            string hashedPassword = loginForm.QuickHash(password);
            int result = loginForm.ValidateLogin(login, hashedPassword);
            Assert.That(result, Is.GreaterThanOrEqualTo(0));
        }
        [Test]
        public void RejestracjaTest()
        {
            var registerForm = new RegisterForm(new Mock<Form>().Object);
            string username = "ProstyLogin";
            string password1 = "ProsteHaslo";
            string password2 = "ProsteHaslo";
            string email = "przyklad@email.pl";
            int result = registerForm.ValidateRegister(username, password1, password2, email);
            Assert.That(result, Is.GreaterThanOrEqualTo(0));
        }
        [Test]
        public void QuickHash_ShouldGenerateCorrectHash()
        {
            // Arrange
            var loginForm = new LoginForm(new Mock<Form>().Object, 1);
            string input = "password";
            string expectedHash = "5E884898DA28047151D0E56F8DC6292773603D0D6AABBDD62A11EF721D1542D8"; // SHA256 hash dla "password"

            // Act
            string hash = loginForm.QuickHash(input);

            // Assert
            Assert.That(expectedHash, Is.EqualTo(hash));
            Console.WriteLine("Uruchomiono test QuickHash");
        }
        [Test]
        public void DodajTerminTest()
        {
            // Arrange
            var mockPanel = new Mock<IPanelUzytkownika>();
            var utworzTermin = new UtworzTermin(mockPanel.Object);
            DateTime dataRozpoczecia = new DateTime(2026, 6, 20);
            DateTime dataZakonczenia = new DateTime(2026, 5, 20); // Korekta daty powinna być zrobiona
            string iloscGodzin1 = "15";
            string iloscMiejsc1 = "15";
            var idInstruktor = 5;
            var idKursRodzaj = 1;

            // Act
            int result = utworzTermin.UtworzTerminExec(dataRozpoczecia, dataZakonczenia, iloscGodzin1, iloscMiejsc1, idInstruktor, idKursRodzaj);

            // Assert
            Assert.That(result, Is.GreaterThanOrEqualTo(0));
            Console.WriteLine("Uruchomiono test DodajTerminTest");
        }
        [Test]
        public void WczytanieTerminowTest()
        {
            // Arrange
            var faktycznyPanel = new PanelUzytkownika(new Mock<Form>().Object); // Użycie rzeczywistej klasy zamiast mocka
            var zapisNaKurs = new ZapisNaKurs(faktycznyPanel);

            int idInstruktor = 5;
            int idKursRodzaj = 1;   // Id dostępnego kursu (1), dla testu z niepowodzeniem zmienić na (0)

            // Act
            int result = zapisNaKurs.LoadTerminy(idKursRodzaj, idInstruktor);

            // Assert
            Assert.That(result, Is.GreaterThanOrEqualTo(0));
            Console.WriteLine("Uruchomiono test DodajTerminTest");
        }

    }
}
