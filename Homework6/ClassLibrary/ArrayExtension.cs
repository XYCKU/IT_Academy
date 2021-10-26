using System;

namespace ClassLibrary
{
	public static class ArrayExtension
	{
		delegate bool Comparator(int a, int b);
		public static void BubbleSort(this int[] array, bool isAscending = true)
		{
			Comparator comp;
			if (isAscending) {
				comp = (int a, int b) => (a > b);
			} else {
				comp = (int a, int b) => (a < b);
			}

			for (int i = 0; i < array.Length - 1; i++) {
				for (int j = i; j < array.Length; j++) {
					if (comp(array[i], array[j])) {
						int temp = array[i];
						array[i] = array[j];
						array[j] = temp;
					}
				}
			}
		}
	}
}
