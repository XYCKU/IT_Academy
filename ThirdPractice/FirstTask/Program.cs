using System;

namespace FirstTask
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Part 1");
			Console.Write("Input array size: ");
			int size = Int32.Parse(Console.ReadLine());
			int[] array = new int[size];
			
			Random rnd = new Random();
			for (int i = 0; i < array.Length; i++) {
				array[i] = rnd.Next() % 200;
				Console.Write($"{array[i]} ");
			}
			Console.WriteLine();
			Console.WriteLine("Part 2");
			for (int i = 0; i < array.Length; i++) {
				if (array[i] >= 10 && array[i] < 100) {
					Console.Write($"{array[i]} ");
				}
			}
			Console.WriteLine();

			Console.WriteLine("Part 3");
			int number = -20;
			int dec = 20;
			do {
				Console.WriteLine(number);
				number -= dec;
			} while (number >= -100);
		}
	}
}
