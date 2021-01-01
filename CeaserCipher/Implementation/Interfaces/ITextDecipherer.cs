
namespace CaesarCipher.Implementation
{
    public interface ITextDecipherer
    {
        string DecryptMessage(string input, int shift = 3);
    }
}
