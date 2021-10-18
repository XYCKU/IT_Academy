using System;

namespace Task1
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = Int32.Parse(Console.ReadLine());
			if (number >= 0) {
				if (number <= 30) {
					Console.WriteLine("First range");
					return;
				}
				if (number <= 60) {
					Console.WriteLine("Second range");
					return;
				}
				if (number <= 100) {
					Console.WriteLine("Third range");
					return;
				}
			}
			Console.WriteLine("I don't know this number");
		}
	}
}
