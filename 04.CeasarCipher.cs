using System;

namespace _04.CaesarCipher
{

// Write a program that returns an encrypted version of the same text. 
// Encrypt the text by shifting each character with three positions forward. 
// For example A would be replaced by D, B would become E, and so on. Print the encrypted text.
// Programming is cool!     ->      Surjudpplqj#lv#frro$


    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            char[] inputTextAsCharArray = inputText.ToCharArray();
            int textLength = inputTextAsCharArray.Length;
            char[] encryptedCharArray = new char[textLength];

            for (int i = 0; i < textLength; i++)
            {
                encryptedCharArray[i] = (char)(inputTextAsCharArray[i]+3);
            }
            string encryptedText = new string(encryptedCharArray);

            Console.WriteLine(encryptedText);
        }
    }
}
