using System;

namespace ThirdTask
{
	class Program
	{
		static void Main(string[] args)
		{
			byte a = 8;
			if ((a & (a - 1)) == 0) {
				Console.WriteLine("Power of 2");
			} else {
				Console.WriteLine("No");
			}
		}
	}
}
