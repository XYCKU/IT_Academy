using System;
using MyLib;

namespace Console1
{
	class Program
	{
		static void Main(string[] args)
		{
			const string validOperators = "+-*/";

			while (true) {
				Console.WriteLine("Input operator");
				char input = Console.ReadLine()[0];
				if (!validOperators.Contains(input)) return;

				Console.WriteLine("Input 2 numbers");
				int a = Int32.Parse(Console.ReadLine());
				int b = Int32.Parse(Console.ReadLine());
				
				int result = 0;
				
				switch(input) {
					case '+': result = Calculator.Add(a, b); break;
					case '-': result = Calculator.Sub(a, b); break;
					case '*': result = Calculator.Multiply(a, b); break;
					case '/': result = Calculator.Divide(a, b); break;
				}
				Console.WriteLine($"{a} {input} {b} = {result}");
			}
		}
	}
}
