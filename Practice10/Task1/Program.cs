using System;
using System.Collections;
using System.Collections.Generic;

namespace Task1
{
	class Program
	{
		static void Print(IEnumerable collection)
		{
			foreach(var item in collection) {
				Console.Write($"{item}, ");
			} Console.WriteLine();
		} 
		static void Main(string[] args)
		{
			List<int> list = new List<int>();
			ArrayList arrayList = new ArrayList();

			list.Add(5);
			Print(list);
			list.Add(7);
			Print(list);
			list.Remove(5);
			Print(list);
			//list.RemoveAt(3);
			//Print(list);
			list.Add(8);
			list.Sort();
			Print(list);

			arrayList.Add("second string");
			Print(arrayList);
			arrayList.Add("first string");
			Print(arrayList);
			//arrayList.RemoveAt(3);
			//Print(arrayList);
			arrayList.Remove("first string");
			Print(arrayList);
			arrayList.Add("first string");
			//arrayList.Add(55);
			arrayList.Sort();
			Print(arrayList);
		}
	}
}
