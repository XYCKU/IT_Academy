using System;

namespace Entities
{
	public class Room
	{
		Printer printer;
		public Room(Printer printer = null)
		{
			this.printer = printer;
		}
		public void MakeThisLazyPrinterWork(string value)
		{
			if (printer == null) return;

			printer.Print(value);
		}
		public void ReplacePrinter(Printer newPrinter)
		{
			if (newPrinter == null) return;

			printer = newPrinter;
		}
	}
}
