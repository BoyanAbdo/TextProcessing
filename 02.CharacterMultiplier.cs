using System;
using System.Linq;

namespace _02.CharacterMultiplier
{

// Create a method that takes two strings as arguments and returns the sum of their character codes 
// multiplied (multiply str1[0] with str2[0] and add to the total sum). 
// Then continue with the next two characters. If one of the strings is longer than the other, 
// add the remaining character codes to the total sum without multiplication.
// Gosho Pesho      ->      53253
// 123 522          ->      7647


    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split();
            char[] word1 = words[0].ToCharArray();
            char[] word2 = words[1].ToCharArray();
            int result = 0;

            if (word1.Length == word2.Length)
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    result += (word1[i] * word2[i]);
                }
            }
            else if (word1.Length < word2.Length) // abc abcde
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    result += (word1[i] * word2[i]);
                }
                for (int i = word1.Length; i < word2.Length; i++)
                {
                    result += word2[i];
                }
            }
            else if (word1.Length > word2.Length) // abcde abc
            {
                for (int i = 0; i < word2.Length; i++)
                {
                    result += (word1[i] * word2[i]);
                }
                for (int i = word2.Length; i < word1.Length; i++)
                {
                    result += word1[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}
