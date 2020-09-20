using System;
using System.Linq;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ENTER TASK NO.: ");
            byte no = byte.Parse(Console.ReadLine());
            if (no == 1)
            {
                Console.WriteLine("enter strings until end");
                string line = Console.ReadLine();
                while (line != "end")
                {
                    string reversed = string.Empty;
                    int l = line.Length;
                    for (int i = l - 1; i >= 0; i--)
                    {
                        reversed += line[i];
                    }
                    Console.WriteLine($"{line} = {reversed}");
                    line = Console.ReadLine();
                }
            }
            else if (no == 2)
            {
                Console.WriteLine("enter strings until end");
                string line = Console.ReadLine();
                var separators = new char[] { ' ', ',', '.' };
                while (line != "end")
                {
                    string[] words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var word in words)
                    {
                        int l = word.Length;
                        for (int i = 0; i < l; i++)
                        {
                            Console.Write(word + " ");
                        }
                    }
                    Console.WriteLine();
                    line = Console.ReadLine();
                }
            }
            else if (no == 3)
            {
                Console.Write("enter string: ");
                string line = Console.ReadLine();
                Console.Write("remove an occurrence: ");
                string occurrence = Console.ReadLine();

                Console.WriteLine(line.Replace(occurrence, string.Empty));
            }
            else if (no == 4)
            {
                Console.WriteLine("enter string with digits, letters and symbols");
                string line = Console.ReadLine();
                string digits = string.Empty;
                string letters = string.Empty;
                string symbols = string.Empty;
                char[] chars = line.ToCharArray();

                foreach (var ch in chars)
                {
                    if (ch >= 48 && ch <= 57)
                    {
                        digits += ch;
                    }
                    else if ((ch >= 65 && ch <= 90) || (ch >= 97 && ch <= 122))
                    {
                        letters += ch;
                    }
                    else if (ch != ' ')
                    {
                        symbols += ch;
                    }
                }
                Console.WriteLine(digits);
                Console.WriteLine(letters);
                Console.WriteLine(symbols);
            }



        }
    }
}
