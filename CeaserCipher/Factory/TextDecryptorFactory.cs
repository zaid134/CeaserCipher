
using CaesarCipher.Implementation;
using CeaserCipher.Implementation;

namespace CaesarCipher.Factory
{
    public static class TextDecryptorFactory
    {
        public static ITextDecipherer GetDecryptor()
        {
            return new TextDecipherer();
        }
    }
}
