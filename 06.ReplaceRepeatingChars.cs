using System;
using System.Text;

namespace _06.ReplaceRepeatingChars
{
// Write a program that reads a string from the console and replaces any sequence of the same letters with a single corresponding letter.

    class Program
    {
        static void Main()
        {
            string inputText = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            if (inputText != string.Empty)
            {
                sb.Append(inputText[0]);
                for (int i = 1; i < inputText.Length; i++)
                {
                    if (inputText[i] != inputText[i - 1])
                    {
                        sb.Append(inputText[i]);
                    }
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
