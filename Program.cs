using System;

namespace FebruaryContestEntry
{
	class Program
	{
		const char block = '▓';

		const int rows = 15;
		const int cols = 30;
		const int first = 0;
		static void Main(string[] args)
		{
			// The solution implementation goes here
			Console.ResetColor();
			// Process the lines
			for (var row = first; row <= rows; row++)
			{
				// Process all columns for a line
				for (var col = first; col <= cols; col++)
				{
					// Determine the color of the block
					Console.BackgroundColor = (col == first || col == cols || row == first || row == rows) 
						? ConsoleColor.Green 
						: ConsoleColor.Yellow;
					// Now write the block
					Console.Write(block);
				}
				// Go to the next line on the console
				Console.WriteLine("");
			}
			Console.ReadLine();
		}
	}
}
