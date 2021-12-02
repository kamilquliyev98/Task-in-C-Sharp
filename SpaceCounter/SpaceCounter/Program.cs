public class Program
{
    public static void Main()
    {
        Console.WriteLine(SpaceCounter("Hello, World! My name is Kamil. I am Web Developer. Thanks!"));
    }

    #region Space Counter Method
    static int SpaceCounter(string str)
    {
        int counter = 0;
        foreach (char item in str)
        {
            if (item == ' ')
            {
                counter++;
            }
        }
        return counter;
    }
    #endregion
    // This code is contributed by Kamil
    // December 2, 2021
}