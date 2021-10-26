using System;

namespace ClassLibrary
{
	public class Book
	{
		public string Name { get; private set; }
		public string LibraryName { get; set; }
		public int PageAmount { get; private set; }
		public Book(string name, int pageAmount, string libraryName = "")
		{
			Name = name;
			PageAmount = pageAmount;
			LibraryName = libraryName;
		}
		public override string ToString() 
		{
			return $"Book Name: {Name}\nLibrary Name: {LibraryName}\nPage Amount: {PageAmount}";
		}
	}
}
