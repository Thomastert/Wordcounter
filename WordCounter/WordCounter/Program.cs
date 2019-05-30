using System;
using System.IO;

namespace WordCounter
{
    class Program
    {
        //Counts the number of individual words in a string.
        //For added complexity read these strings in from a text file and generate a summary.
        static void Main(string[] args)
        {
            string userImput = File.ReadAllText(@"D:\c#practis\rapidfire\StringWordCounter\WordList.txt");
            var wordList = 1;

            for (int i = 0; i < userImput.Length; i++)
            {
                if (userImput[i] == ' ')
                {
                    wordList++;
                }
            }
            Console.WriteLine(wordList);


            Console.WriteLine("end");
            Console.ReadKey();
        }
    }
}
