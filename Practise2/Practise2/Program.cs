using System;

namespace Practise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { -1, 0, 1, -12, 3, 4, 5, 6, 7, 8, 9, -10, -2 };

            Finder find = new Finder();
            find.Find(array);
        }
    }
}
