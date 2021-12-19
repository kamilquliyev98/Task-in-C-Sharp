using System;

namespace Practise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, -3, -2, -1, 100, -100, 999, -999, -1998 };

            Calculator calc = new Calculator();
            Console.WriteLine($"Array daxilinde ucreqemli ededlerin cemi ile diger ededlerin cemi arasindaki ferq:\n{calc.Calculate(array)}");
        }
    }
}
