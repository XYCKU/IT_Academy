using System;

namespace Entities
{
	public class BluePrinter : Printer
	{
		readonly ConsoleColor printColor = ConsoleColor.Blue;
		public override void Print(string value)
		{
			base.Print(value, printColor);
		}
	}
}
