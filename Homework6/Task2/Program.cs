using System;
using ClassLibrary;

namespace Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] a = new int[] { 5, 6, 3, 7, 9, 6, 8 };
			a.BubbleSort();
			foreach(var item in a) {

				Console.Write($"{item} ");
			}
			Console.WriteLine();
		}
	}
}
