using CaesarCipher.Factory;
using System;

namespace CeaserCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            //enter encrypted message
            Console.WriteLine("Enter your encrypted message:");

            string input= Console.ReadLine();

            //decrypt the message
             string decryptedMessage = TextDecryptorFactory.GetDecryptor().DecryptMessage(input);

            //print decrypted message
            Console.WriteLine($"Your decrypted message is: {decryptedMessage}");
            Console.ReadLine();
        }
    }
}
