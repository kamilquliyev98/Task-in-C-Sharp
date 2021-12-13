using System;

namespace Library
{
    public class Calculator
    {
        public double result { get; set; }

        public double Calc(double x, char op, double y)
        {
            switch (op)
            {
                case '+':
                    result = x + y;
                    break;
                case '-':
                    result = x - y;
                    break;
                case '*':
                case 'x':
                    result = x * y;
                    break;
                case '/':
                case ':':
                    result = x / y;
                    break;
                default:
                    result = 0;
                    break;
            }
            return result;
        }
    }
}
