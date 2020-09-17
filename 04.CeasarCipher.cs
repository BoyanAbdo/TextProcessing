using System;

namespace _04.CaesarCipher
{
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
