/*!
 * This code is contributed by Kamil Guliyev
 *
 * Email: kamilag@code.edu.az
 *
 * Date: 2021-12-02
 */
using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(Calculate(5, '%', 2));
    }

    static double Calculate(double a, char op, double b)
    {
        switch (op)
        {
            case '+':
                return a + b;
            case '-':
                return a - b;
            case '*':
                return a * b;
            case '/':
            case ':':
                return a / b;
            case '%':
                return (a * b) / 100;
            default:
                return 0;
        }
    }
}