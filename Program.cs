using System;
using System.Linq;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main()
        {
            string[] names = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var name in names)
            {
                bool isValid = false;
                if (name.Length >= 3 && name.Length <= 16)
                {
                    isValid = CheckName(name);
                }
                if (isValid)
                {
                    Console.WriteLine(name);
                }
            }

        }

        private static bool CheckName(string name)
        {
            char[] toChars = name.ToCharArray();
            foreach (var ch in toChars)
            {
                if (!((ch >= 48 && ch <= 57) || (ch >= 65 && ch <= 90)
                    || (ch >= 97 && ch <= 122) || ch=='-'||ch=='_'))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
