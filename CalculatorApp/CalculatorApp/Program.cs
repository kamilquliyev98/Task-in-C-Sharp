using Library;
using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            double result = calc.Calc(0.5, '/', 0.05);
            Console.WriteLine(result);
        }
    }
}
