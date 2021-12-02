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

		#region Daxil edilən rəqəmə görə ilin hansı fəsli olduğunu ekrana yazdıran alqoritm

		int month = 12;

		switch (month)
		{
			case 1:
			case 2:
			case 12:
				Console.WriteLine("Winter");
				break;
			case 3:
			case 4:
			case 5:
				Console.WriteLine("Spring");
				break;
			case 6:
			case 7:
			case 8:
				Console.WriteLine("Summer");
				break;
			case 9:
			case 10:
			case 11:
				Console.WriteLine("Autumn (Fall)");
				break;
			default:
				Console.WriteLine("Düzgün daxil edin.");
				break;
		}

		#endregion

	}
}