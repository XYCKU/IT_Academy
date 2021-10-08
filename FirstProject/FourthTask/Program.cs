using System;

namespace FourthTask
{
	class Program
	{
		static void Main(string[] args)
		{
			const int amount = 3;
			int[] array = new int[amount];

			for (int i = 0; i < amount; i++) {
				array[i] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine($"Second element value is {array[1]}");
		}
	}
}
