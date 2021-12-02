public class Program
{
    public static void Main()
	{

		#region Ədədin mürəkkəb və ya sadə olduğunu tapan alqoritm

		int number = 571;
		int counter = 0;

		if (number <= 0)
		{
			Console.WriteLine("Please, enter positive number.");
		}
		else if (number == 1)
		{
			Console.WriteLine(number + " is also neither prime nor composite.");
		}
		else
		{
			for (int i = 1; i <= number; i++)
			{
				if (number % i == 0)
				{
					counter++;
				}
			}

			if (counter > 2)
			{
				Console.WriteLine(number + " is composite number.");
			}
			else
			{
				Console.WriteLine(number + " is prime number.");
			}
		}

		#endregion
		// This code is contributed by Kamil
		// December 2, 2021

	}
}