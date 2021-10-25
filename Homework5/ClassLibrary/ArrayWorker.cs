namespace ClassLibrary
{
	static public class ArrayWorker
	{
		public static T[] Invert<T>(T[] array)
		{
			for (int i = 0; i < array.Length / 2; ++i) {
				T temp = array[i];
				array[i] = array[array.Length - i - 1];
				array[array.Length - i - 1] = temp;
			}
			return array;
		}
		public static int[] InsertValue(int[] array, int index, int value)
		{
			int[] newArray = new int[array.Length + 1];
			for (int i = 0; i < index; i++) {
				newArray[i] = array[i];
			}
			newArray[index] = value;
			for (int i = index; i < array.Length; i++) {
				newArray[i + 1] = array[i];
			}
			return newArray;
		}
	}
}
