using System;
using System.Collections.Generic;
using System.Text;

namespace Practise1
{
    class Finder
    {
        public void Find(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Musbet eded daxil edin...");
            }
            else
            {
                int x = n;

                while (x % 2 == 0)
                {
                    x /= 2;
                }

                if (x == 1)
                {
                    Console.WriteLine($"{n} 2 ededinin quvvetidir.");
                }
                else
                {
                    Console.WriteLine($"{n} 2 ededinin quvveti deyil.");
                }
            }
        }
    }
}
