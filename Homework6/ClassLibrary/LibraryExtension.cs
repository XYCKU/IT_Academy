namespace ClassLibrary
{
	public static class LibraryExtension
	{
		public static Book GetBiggestBook(this Library library)
		{
			return library.BiggestBook;
		}
	}
}
