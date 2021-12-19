using System;
using System.Collections.Generic;
using System.Text;

namespace Practise10
{
    class ArrayCreator
    {
        public void Create(int[] arr)
        {
            int[] odd = { }; // tek
            int[] even = { }; // cut

            foreach (int item in arr)
            {
                if (item != 0)
                {
                    if (item % 2 == 0)
                    {
                        Array.Resize(ref even, even.Length + 1);
                        even[even.Length - 1] = item;
                    }
                    else
                    {
                        Array.Resize(ref odd, odd.Length + 1);
                        odd[odd.Length - 1] = item;
                    }
                }
            }

            Console.WriteLine("Cut ededlerden ibaret array'in elementleri:");
            foreach (int item in even)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nTek ededlerden ibaret array'in elementleri:");
            foreach (int item in odd)
            {
                Console.WriteLine(item);
            }
        }
    }
}
