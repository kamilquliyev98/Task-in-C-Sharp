using System;

namespace Practise8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 5, 4, 3, 2, 1, 5 };
            int[] array2 = { 10, 9, 8, 7, 6 };

            BringTogetherAndSort order = new BringTogetherAndSort();
            order.Do(array1, array2);
        }
    }
}