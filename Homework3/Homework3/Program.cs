using System;

namespace Task1
{
	class Program
	{
		static void Main(string[] args)
		{
			const float PI = 3.14f;
			Console.WriteLine("Input radius");
			float radius = float.Parse(Console.ReadLine());
			Console.WriteLine("Input length");
			float length = float.Parse(Console.ReadLine());
			float square = PI * radius * (radius + length);
			Console.WriteLine($"Square = {square}");
		}
	}
}
