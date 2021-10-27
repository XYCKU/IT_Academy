using System;

namespace Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			int[][] array = new int[][]
			{
				new int[]{ 5, 8, 9},
				new int[]{ 2, 5, 6 },
				new int[]{ 53, 32, 1 }
			};
			for (int i = 0; i < array.Length; i++) {
				int max = array[i][0];
				for (int j = 0; j < array[i].Length; j++) {
					if (max < array[i][j]) {
						max = array[i][j];
					}
				}
				Console.WriteLine(max);
			}
		}
	}
}
