using System;
using System.Collections.Generic;
using System.Text;

namespace Practise9
{
    class MinMaxFinder
    {
        public void Find(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];

            foreach (int item in arr)
            {
                if (item <= min)
                {
                    min = item;
                }

                if (item >= max)
                {
                    max = item;
                }
            }

            Console.WriteLine($"Min: {min}\nMax: {max}");
        }
    }
}
