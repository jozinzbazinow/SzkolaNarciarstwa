using NUnit.Framework;
using Moq;
using SzkolaNarciarstwa;

namespace SzkolaNarciarstwa.Tests
{
    [TestFixture]
    public class LoginFormTests
    {
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