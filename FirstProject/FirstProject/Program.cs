using System;

namespace FirstProject
{
	class Program
	{
		static void Main(string[] args)
		{
			const int minHits = 1, maxHits = 5;

			Console.Write("Input nails amount: ");
			int nailsAmount = int.Parse(Console.ReadLine());

			if (nailsAmount < 1 || nailsAmount > 10) {
				Console.WriteLine("Wrong amount!");
				return;
			}

			Random rnd = new Random();

			for (int i = 0; i < nailsAmount; i++) {

				int hitsToNail = rnd.Next(minHits, maxHits + 1);
				Console.WriteLine($"{hitsToNail} hits to nail.");

				for (int j = 0; j < hitsToNail; j++) {
					Console.WriteLine("A hit!");
				}

				Console.WriteLine("Nailed one!");
			}

			Console.WriteLine("We did it!");
		}
	}
}
