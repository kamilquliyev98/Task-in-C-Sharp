using System;
using System.Collections.Generic;
using System.Text;

namespace Practise2
{
    class Finder
    {
        public void Find(int[] arr)
        {
            int min = arr[0];
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <= min)
                {
                    min = arr[i];
                    index = i;
                }
            }

            Console.WriteLine($"Arrayin en kicik elementi: {min}\nIndex: {index}");
        }
    }
}
