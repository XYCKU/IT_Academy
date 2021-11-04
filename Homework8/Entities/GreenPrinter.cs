using System;

namespace Entities
{
	public class GreenPrinter : Printer
	{
		readonly ConsoleColor printColor = ConsoleColor.Green;
		public override void Print(string value)
		{
			base.Print(value, printColor);
		}
	}
}
