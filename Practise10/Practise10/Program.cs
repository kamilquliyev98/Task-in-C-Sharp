using System;

namespace Practise10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            ArrayCreator create = new ArrayCreator();
            create.Create(array);
        }
    }
}
