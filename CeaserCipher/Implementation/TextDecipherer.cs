using CaesarCipher.Implementation;
using CaesarCipher.Utility;
using System;

namespace CeaserCipher.Implementation
{
    public class TextDecipherer: ITextDecipherer
    {
        readonly char[] alphabet = new char[26] 
        { 'a','b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
        'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 
        'u', 'v', 'w', 'x', 'y', 'z' };

        public string DecryptMessage(string input, int shift = 3)
        {
            try
            {
                // Validate if input string only contains lower case alphabets
                bool validInput = input.ContainsOnlyLowerCaseAlphabeticalCharacters();

                if (validInput)
                { 
                    char[] encryptedMessage = input.ToLower().ToCharArray();
                    char[] decryptedMessage = new char[encryptedMessage.Length];

                    //loop through the input text one by one to decrypt the message
                    for (int i = 0; i < encryptedMessage.Length; i++)
                    {
                        char letter = encryptedMessage[i];
                        //find the index position of encrypted message character in alphabet
                        int letterPosition = Array.IndexOf(alphabet, letter);
                        // shift the position of character to right based on 'shift' value
                        int decryptedLetterPosition = (letterPosition + shift) % 26;
                        //decrypt the character
                        char decryptedLetter = alphabet[decryptedLetterPosition];
                        decryptedMessage[i] = decryptedLetter;
                    }
                    //return the decrypted message
                    return String.Join("", decryptedMessage);
                }
                else
                {
                    return "Invalid input: Input text can only contain lower case alphabets.";
                }
            }
           catch(Exception)
            {
                return "Unable to decrypt the message due to program errorr." ;
            }
            
        }

        }
    }

