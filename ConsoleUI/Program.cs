using System;

namespace ConsoleUI
{
	internal class Program
	{
		private static void Main()
		{
			int[] numbers = new int[] { 1, 42, 34, 56, 13 };

			for ( int i = 0; i <= numbers.Length; i++ )
			{
				try
				{
					Console.WriteLine($"The number at position {i} is {numbers[i]}");
				}
				catch ( Exception ex )
				{
					Console.WriteLine("We had an error");
					Console.WriteLine(ex);
				}
			}

			_ = Console.ReadLine();
		}
	}
}
