using CeaserCipher.Implementation;
using Xunit;

namespace CaesarCipher.UnitTest
{
    public class TextDeciphererTest
    {

        [Fact]
        public void Decipher_Text_Success()
        {
            //Arrange
            string input = "nrfzh";

            //Act
            var SUT = new TextDecipherer();
            var decryptedMessage = SUT.DecryptMessage(input);

            //Assert
            Assert.True(decryptedMessage.Equals("quick"));
        }
        [Fact]
        public void Decipher_Text_Failed_UpperCaseInput()
        {
            //Arrange
            string input = "NRFZH";

            //Act
            var SUT = new TextDecipherer();
            var decryptedMessage = SUT.DecryptMessage(input);

            //Assert
            Assert.False(decryptedMessage.Equals("quick"));
            Assert.False(decryptedMessage.Equals("QUICK"));
            Assert.Contains("Invalid input", decryptedMessage);
        }
        [Fact]
        public void Decipher_Text_Failed_SpecialCharacters()
        {
            //Arrange
            string input = "nrfzh@#";

            //Act
            var SUT = new TextDecipherer();
            var decryptedMessage = SUT.DecryptMessage(input);

            //Assert
            Assert.Contains("Invalid input", decryptedMessage);
        }

        [Fact]
        public void Decipher_Text_Failed_Space()
        {
            //Arrange
            string input = "hello world";

            //Act
            var SUT = new TextDecipherer();
            var decryptedMessage = SUT.DecryptMessage(input);

            //Assert
            Assert.Contains("Invalid input", decryptedMessage);
        }
    }
}
