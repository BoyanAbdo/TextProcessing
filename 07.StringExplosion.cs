using System;
using System.Text;

namespace _07.StringExplosion
{

// Explosions are marked with '>'. Immediately after the mark, there will be an integer, which signifies the strength of the explosion.
// You should remove x characters (where x is the strength of the explosion), starting after the punch character ('>').
// If you find another explosion mark ('>') while you’re deleting characters, you should add the strength to your previous explosion.
// When all characters are processed, print the string without the deleted characters. 
// You should not delete the explosion character – '>', but you should delete the integers, which represent the strength. 
   
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

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
