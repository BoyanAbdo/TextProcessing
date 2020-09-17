using System;
using System.Linq;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string[] tokens = path.Split("\\");
            int len = tokens.Length;
            string[] fileFullName = tokens[len - 1].Split(".");

            string fileName = fileFullName[0];
            string fileExtension = fileFullName[1];
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
