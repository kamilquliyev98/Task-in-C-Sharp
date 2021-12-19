using System;
using System.Collections.Generic;
using System.Text;

namespace Practise5
{
    class Counter
    {
        public void Count(string str)
        {
            int counter = 0;
            string[] arr = str.Split(' ');

            foreach (string item in arr)
            {
                if (item == "the" || item == "The")
                {
                    counter++;
                }
            }

            Console.WriteLine($"The frequency of the word 'the' is: {counter}");
        }
    }
}
