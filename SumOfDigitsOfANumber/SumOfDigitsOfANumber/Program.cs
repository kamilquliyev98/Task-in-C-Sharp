public class Program
{
	public static void Main()
	{

		#region Ədədin rəqəmlərinin cəmini tapan alqoritm

		int n = 224;
		n = Math.Abs(n);
		int sum = 0;

		while (n != 0)
		{
			sum += n % 10;
			n /= 10;
		}

		Console.WriteLine(sum);

		#endregion
		// This code is contributed by Kamil
		// December 2, 2021

	}
}