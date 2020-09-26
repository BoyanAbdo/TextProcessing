using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.MultiplyBigNumber
{

// You are given two lines – the first one can be a really big number (0 to 1050). 
// The second one will be a single digit number (0 to 9). You must display the product of these numbers.
// Note: do not use the BigInteger class.


    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine(); // 123812093812038
            int length = firstNumber.Length;
            int secondNumber = int.Parse(Console.ReadLine());

            char[] firstNumberChars = firstNumber.ToCharArray();
            int[] firstNumberDigits = new int[length];
            int[] resultDigits = new int[length];

            for (int i = 0; i < length; i++)
                firstNumberDigits[i] = int.Parse(firstNumberChars[i].ToString());

            // going backwards
            for (int i = length - 1; i >= 0; i--)
            {
                int product = firstNumberDigits[i] * secondNumber;

                resultDigits[i] += product % 10;
                resultDigits[i-1] += product / 10;

                if (resultDigits[i] >= 10)
                {
                    resultDigits[i + 1] %= 10; 
                    resultDigits[i] += resultDigits[i + 1] / 10;
                }
                if (resultDigits[i] >= 10)
                {
                    resultDigits[i] %= 10;
                    if (i != 0)
                        resultDigits[i - 1] += resultDigits[i] / 10;
                }
            }

            if (resultDigits[0] == 0)
            {
                string result = string.Empty;
                for (int i = 1; i < resultDigits.Length; i++)
                {
                    result += resultDigits[i] + "";
                }
                Console.WriteLine(result);
            }
            else
            {
                string result = String.Join("", resultDigits);
                Console.WriteLine(result);
            }

        }

        private static string Reverse(string result)
        {
            char[] arr = result.ToCharArray();
            Array.Reverse(arr);
            return arr.ToString();
        }
    }
}
