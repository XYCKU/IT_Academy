using System;

namespace ThirdTask
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = new int[] { 1, 2, 3, 4, 5 };
			int i = 0;

			marker:
			Console.WriteLine(array[i++]);
			if (i < array.Length) {
				goto marker;
			}
		}
	}
}
