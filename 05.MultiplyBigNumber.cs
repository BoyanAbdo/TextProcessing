using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.MultiplyBigNumber
{
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
            //  String.Join("", new List<int>(array).ConvertAll(i => i.ToString()).ToArray());

            //Console.WriteLine(Reverse(result));

        }

        private static string Reverse(string result)
        {
            char[] arr = result.ToCharArray();
            Array.Reverse(arr);
            return arr.ToString();
        }
    }
}
