using System;

namespace Practise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "The string where the word the present more than once.";

            Counter count = new Counter();
            count.Count(text);
        }
    }
}
