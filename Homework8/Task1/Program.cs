using System;
using Entities;

namespace Task1
{
	class Program
	{
		static void Main(string[] args)
		{
			Printer printer = new Printer();
			Room myRoom = new Room(printer);
			myRoom.MakeThisLazyPrinterWork("this is gray");
			myRoom.ReplacePrinter(new GreenPrinter());
			myRoom.MakeThisLazyPrinterWork("this is green");
			myRoom.ReplacePrinter(new BluePrinter());
			myRoom.MakeThisLazyPrinterWork("this is blue");

			Console.WriteLine("Not a printer");
		}
	}
}
