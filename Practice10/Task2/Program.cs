using System;
using Models;

namespace Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			MyList<string> list = new MyList<string>();
			list.Add("bbasa");
			list.Add("za");
			list.Add("a");
			foreach(var item in list) {
				Console.WriteLine(item);
			}
		}
	}
}
