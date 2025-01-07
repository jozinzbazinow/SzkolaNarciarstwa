using NUnit.Framework;
using Moq;
using SzkolaNarciarstwa;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SzkolaNarciarstwa.Tests
{
    [TestFixture]
    public class LoginFormTest2
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
            bool result = registerForm.ValidateRegister(username, password1, password2, email);
            Assert.That(result, Is.True);
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
    }
}
