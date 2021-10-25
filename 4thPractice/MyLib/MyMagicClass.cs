using System;
using System.Collections.Generic;

namespace MyLib
{
	static class MyMagicClass
	{
		static readonly int[] dividers = new int[] { 2, 3, 5, 6, 9 };
		static public bool IsPositive(int value)
		{
			return value >= 0;
		}
		static public string CanBeDivided(int value)
		{
			List<string> answers = new List<string>();
			foreach (int divider in dividers) {
				if (value % divider == 0) {
					answers.Add($"Can be divided by {divider}");
				}
			}

			return String.Join(", ", answers);
		}
		static public int[] DivideableBy3(params int[] values)
		{
			List<int> result = new List<int>();
			foreach(int value in values) {
				if (value % 3 == 0) {
					result.Add(value);
				}
			}
			return result.ToArray();
		}
 	}
}
