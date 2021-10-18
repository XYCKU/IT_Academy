using System;

namespace SecondTask
{
	class Program
	{
		static void Main(string[] args)
		{
			char input = Console.ReadKey().KeyChar;
			Console.WriteLine();
			string message = input switch { 
				'w' => "Go forward",
				's' => "Go back",
				'd' => "Go right",
				'a' => "Go left",
				_ => "Nowhere to go"
			};
			Console.WriteLine(message);

		}
	}
}
