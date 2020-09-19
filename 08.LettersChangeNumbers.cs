using System;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main()
        {
            string inputLine = Console.ReadLine();
            string[] tokens = inputLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            // P34562Z q2576f   H456z

            decimal sum = 0;
            foreach (var token in tokens)
            {
                int len = token.Length;
                char prefix = token[0];
                char suffix = token[len - 1];
                int number = int.Parse(token.Substring(1, len - 2));

                decimal currentSum = 0;

                if (prefix >=65 && prefix <= 90) // uppercase
                {
                    decimal divider = prefix - 64;
                    currentSum += number / divider;
                }
                else if (prefix>=97 && prefix<=122) //lowercase
                {
                    decimal multiplier = prefix - 96;
                    currentSum += number * multiplier;
                }

                if (suffix >= 65 && suffix<= 90) // uppercase
                {
                    currentSum -= (suffix - 64);
                }
                else if (suffix >= 97 && suffix <= 122) //lowercase
                {
                    currentSum += (suffix - 96);
                }

                sum += currentSum;
            }
            Console.WriteLine($"{sum:F2}");




        }
    }
}
