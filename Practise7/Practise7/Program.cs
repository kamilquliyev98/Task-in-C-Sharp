using System;

namespace Practise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            ReverseSorting sort = new ReverseSorting();
            sort.Sort(array);
        }
    }
}
