using System;
using System.Collections.Generic;

namespace Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			int i = 201;
			int inc = 1;
			List<int> numbers = new List<int>();
			while (i < 500) {
				if (i % 17 == 0) {
					numbers.Add(i);
					inc = 17;
				}
				i += inc;
			}
			Console.WriteLine(String.Join<int>(", ", numbers));
		}
	}
}
