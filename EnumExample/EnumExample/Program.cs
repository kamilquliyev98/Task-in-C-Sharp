using System;

namespace EnumExample
{
    class Program
    {
        public enum Months { January = 1, February, March, April, May, June, July, August, September, October, November, December };
        static void Main(string[] args)
        {
            int? id = null;
            switch (id)
            {
                case (int)Months.January:
                    Console.WriteLine("January");
                    break;
                case (int)Months.February:
                    Console.WriteLine("February");
                    break;
                case (int)Months.March:
                    Console.WriteLine("March");
                    break;
                case (int)Months.April:
                    Console.WriteLine("April");
                    break;
                case (int)Months.May:
                    Console.WriteLine("May");
                    break;
                case (int)Months.June:
                    Console.WriteLine("June");
                    break;
                case (int)Months.July:
                    Console.WriteLine("July");
                    break;
                case (int)Months.August:
                    Console.WriteLine("August");
                    break;
                case (int)Months.September:
                    Console.WriteLine("September");
                    break;
                case (int)Months.October:
                    Console.WriteLine("October");
                    break;
                case (int)Months.November:
                    Console.WriteLine("November");
                    break;
                case (int)Months.December:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Does not match...");
                    break;
            }
        }
    }
}
