using System;
using System.Collections.Generic;
using System.Text;

namespace Practise7
{
    class ReverseSorting
    {
        public void Sort(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
