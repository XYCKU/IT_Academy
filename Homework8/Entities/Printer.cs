using System;

namespace Entities
{
	public class Printer
	{
		readonly ConsoleColor printColor = ConsoleColor.Gray;
		public virtual void Print(string value)
		{
			Print(value, printColor);
		}
		public void Print(string value, ConsoleColor textColor)
		{
			var lastColor = Console.ForegroundColor;
			Console.ForegroundColor = textColor;
			Console.WriteLine(value);
			Console.ForegroundColor = lastColor;
		}
	}
}
