namespace Spoleto.Cryptography.Rsa.Tests
{
    public class Tests
    {
        private Certificate _certificate;

        [SetUp]
        public void Setup()
        {
            _certificate = TestData.TestCertificate;
        }

        [Test]
        public void CreateCertificate()
        {
            // Arrange
            var email = "admin@test.com";

            // Act
            var certificate = RSACryptoPemHelper.CreateCertificate(_certificate.Body, _certificate.PrivateKey);

            // Assert
            Assert.That(certificate, Is.Not.Null);
            Assert.That(certificate.IssuerName.Name, Does.Contain(email));
        }

        [Test]
        public void CryptoVerify()
        {
            // Arrange
            var data = "String to sign";

            // Act
            var signedData = RSACryptoPemHelper.Sign(_certificate.PrivateKey, data);
            var isVerified = RSACryptoPemHelper.Verify(_certificate.Body, data, signedData);

            // Assert
            Assert.That(isVerified, Is.True);
        }
    }
}