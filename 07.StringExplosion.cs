using System;
using System.Text;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine(); // 1234
            //StringBuilder sb = new StringBuilder();
            //string result = string.Empty;

            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] == '>')
                {

                    if (i != input.Length - 1 && Int32.TryParse(input[i + 1] + "", out int str))
                    {
                        int strength = int.Parse(input[i + 1] + "");
                        strength += count;
                        count = 0;
                        for (int j = 0; j < strength; j++)
                        {
                            if ((i + 1) >= input.Length || input[i + 1] == '>')
                            {
                                break;
                            }
                            else
                            {

                                input = input.Remove(i + 1, 1);
                                count++;
                            }
                        }
                        count = strength - count; // if str = 2, count = 2 => count = 0
                    }

                }


            }
            Console.WriteLine(input);

        }
    }
}
