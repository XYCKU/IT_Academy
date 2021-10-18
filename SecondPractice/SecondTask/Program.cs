using System;

namespace SecondTask
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 2;
			if ((a & 1) != 0) {
				Console.WriteLine($"Number {a} is odd.");
			} else {
				Console.WriteLine($"Number {a} is even.");
			}
		}
	}
}