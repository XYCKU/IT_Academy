using System;

namespace FirstTask
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = Convert.ToInt32(Console.ReadLine());
			if (a % 2 == 0) {
				Console.WriteLine($"Number {a} is even.");
			} else {
				Console.WriteLine($"Number {a} is odd.");
			}
		}
	}
}
