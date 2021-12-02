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
        Console.WriteLine(Exist("hello", 'e'));
    }

    static bool Exist(string str, char chr)
    {
        foreach (char item in str)
        {
            if (item == chr)
            {
                return true;
            }
        }
        return false;
    }
}