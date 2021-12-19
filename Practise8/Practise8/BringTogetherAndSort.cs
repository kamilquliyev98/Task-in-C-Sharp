using System;
using System.Collections.Generic;
using System.Text;

namespace Practise8
{
    class BringTogetherAndSort
    {
        public void Do(int[] arr1, int[] arr2)
        {
            foreach (int item in arr2)
            {
                Array.Resize(ref arr1, arr1.Length + 1);
                arr1[arr1.Length - 1] = item;
            }

            Array.Sort(arr1);
            Array.Reverse(arr1);

            foreach (int item in arr1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
