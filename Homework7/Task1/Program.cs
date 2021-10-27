using System;

namespace Task1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = new int[6];
			for (int i = 0; i < array.Length; i++) {
				array[i] = int.Parse(Console.ReadLine());
			}
			Array.Sort(array);
			foreach(var item in array) {
				Console.Write($"{item} ");
			}
		}
	}
}
