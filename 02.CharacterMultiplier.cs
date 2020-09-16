using System;
using System.Linq;

namespace _02.CharacterMultiplier
{
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
