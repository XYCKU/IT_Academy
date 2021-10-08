using System;

namespace ThirdTask
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(' ');
			const int amount = 3;
			float sum = 0;

			for (int i = 0; i < amount; i++) {
				sum += int.Parse(input[i]);
			}
			sum /= amount;
			Console.WriteLine(sum);
		}
	}
}
