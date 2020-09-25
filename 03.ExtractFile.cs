using System;
using System.Linq;

namespace _03.ExtractFile
{

//Write a program that reads the path to a file and subtracts the file name and its extension.
//C:\Internal\training-internal\Template.pptx ->    File name: Template
                                                //  File extension: pptx
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
