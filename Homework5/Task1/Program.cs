using System;
using ClassLibrary;

namespace Task1
{
	class Program
	{
		static void Main(string[] args)
		{
			// Task 1
			{
				int[] array = new int[] { 5, 7, 8, 4 };
				int[] result = ArrayWorker.Invert(array);
				foreach (var item in result) {
					Console.Write($"{item} ");
				}
				Console.WriteLine();

			}
			// Task 2
			{
				int[] array = new int[] { 5, 7, 8, 4 };
				int[] result = ArrayWorker.InsertValue(array, 3, 66);
				foreach (var item in result) {
					Console.Write($"{item} ");
				}
				Console.WriteLine();
			}

			// Task 3
			{
				Cone cone = new Cone(2f, 5f);
				Console.WriteLine($"Basement Square: {cone.GetBasementSquare()}\nFull Square: {cone.GetFullSquare()}");
			}
		}
	}
}
