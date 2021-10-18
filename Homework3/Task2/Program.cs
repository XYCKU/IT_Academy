using System;

namespace Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = 14, y = 1, z = 5;
			Console.WriteLine($"x = {x}\ty = {y}\tz = {z}");
			x += y - x++ * z;
			Console.WriteLine($"x = {x}\ty = {y}\tz = {z}");
			z = --x - y * 5;
			Console.WriteLine($"x = {x}\ty = {y}\tz = {z}");
			y /= x + 5 % z;
			Console.WriteLine($"x = {x}\ty = {y}\tz = {z}");
			z = x++ + y * 5;
			Console.WriteLine($"x = {x}\ty = {y}\tz = {z}");
			x = y - x++ * z;
			Console.WriteLine($"x = {x}\ty = {y}\tz = {z}");
		}
	}
}
