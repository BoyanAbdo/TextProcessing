using System;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace TextProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            // lecture Strings SoftUni Fundamentals May 2019

            var text = "ha bab gaga";
            var array = text.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < array.Length; i++)
            {
                var word = array[i];
                int len = word.Length;
                for (int j = 0; j < len; j++)
                {
                    Console.Write(word);
                }
                Console.WriteLine();
            }

            Console.WriteLine("-------");
            string sometext = "banana, kiwi, peach, mango";
            Console.WriteLine(sometext);
            Console.WriteLine(sometext.IndexOf("kiwi"));
            Console.WriteLine(sometext.IndexOf("o"));
            Console.WriteLine(sometext.IndexOf("oh"));
            Console.WriteLine(sometext.Contains("ban"));
            Console.WriteLine(sometext.LastIndexOf("i"));
            Console.WriteLine(sometext.Substring(9));
            Console.WriteLine(sometext.Substring(2, 2));

            Console.WriteLine("-------");
            string txt = "kicegiceiceb";
            string key = "ice";
            var newtext = txt.Replace(key, "");
            Console.WriteLine(newtext);

            Console.WriteLine("-------");
            string txt2 = "Hello, john@softuni.bg, " +
                "you have been using john @softuni.bg in your registration";
            string[] words = txt2.Split(", ");
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("-------");
            var separators = new char[] { ' ', ',', '.' };
            string txt3 = "hello, i am John, the bad guy...";
            string[] words2 = txt3.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words2)
            {
                Console.WriteLine(word);
            }


            Console.WriteLine("-------");
            var txt4 = "toooooooooosome other textotexot ot oooteeloo";
            Console.WriteLine(txt4);
            var index = -1;
            while (true)
            {
                index = txt4.IndexOf('t', index + 1);
                if (index < 0)
                {
                    break;
                }
                Console.WriteLine(index);
            }

            Console.WriteLine();
            var searchedTerm = "ooo";
            index = -(searchedTerm.Length);
            while (true)
            {
                index = txt4.IndexOf(searchedTerm, index + searchedTerm.Length);
                if (index < 0)
                {
                    break;
                }
                Console.WriteLine(index);
            }
            Console.WriteLine();
            var lastIndex = txt4.Length;
            while (lastIndex > 0)
            {
                lastIndex = txt4.LastIndexOf('t', lastIndex - 1);
                if (lastIndex > 0)
                {
                    Console.WriteLine(lastIndex);
                }
            }

            Console.WriteLine("-------");
            var bannedWords = new string[]{ "Linux", "Windows", "is" };
            var textForEdit = "It is not Linux, it is GNU/Linux. Linux " +
                "is merely the kernel, while GNU adds the functionality... And Windows is good for some gaming";
            foreach (var word in bannedWords)
            {
                if (textForEdit.Contains(word))
                {
                    int l = word.Length;
                    textForEdit = textForEdit.Replace(word, new string('*', l));
                }
            }
            Console.WriteLine(textForEdit);

            Console.WriteLine("-------");
            var theText = "asdkpasdjnq asdkoqppqndn asd";
            Console.WriteLine(theText);
            var ch = 'a';
            var result = theText.Count(s=>s==ch);
            Console.WriteLine($"'{ch}' how many times? {result}");


            //String Builder:
            Console.WriteLine("-------");
            var stopwatch = Stopwatch.StartNew();
            int testLen = 1000;
            
            StringBuilder sb = new StringBuilder();
            //char chch = 'a';
            for (int i = 0; i < testLen; i++)
            {
                //sb.Append(chch++);
                sb.Append(i);
            }

            var result2 = sb.ToString();
            Console.WriteLine(stopwatch.Elapsed);

            sb.Clear();
            stopwatch = Stopwatch.StartNew();
            var newLongtext = string.Empty;
            for (int i = 0; i < testLen; i++)
            {
                newLongtext += i;
            }
            Console.WriteLine(stopwatch.Elapsed);
            Console.WriteLine("-------");

            sb.Clear();
            sb.AppendFormat("{0}", 5);
            Console.WriteLine(sb);
        }
    }
}
