using System;

namespace SecondTask
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("What's your name?");
			string userName = Console.ReadLine();
			string helloMessage = $"Hi, {userName}";
			Console.WriteLine(helloMessage);
		}
	}
}
