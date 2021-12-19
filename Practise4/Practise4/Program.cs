using System;

namespace Practise4
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "This is Code Academy!";

            WordCounter count = new WordCounter();
            Console.WriteLine($"Total number of words in the string is: {count.Count(text)}");
        }
    }
}
