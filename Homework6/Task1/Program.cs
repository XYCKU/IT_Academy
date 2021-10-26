using System;
using ClassLibrary;

namespace Task1
{
	class Program
	{
		static void CheckBook(Book book)
		{
			if (book != null) {
				Console.WriteLine(book);
			} else {
				Console.WriteLine("No such book");
			}
		}
		static void Main(string[] args)
		{
			Book math = new Book("Math", 99);
			Book philosophy = new Book("Philosophy", 25);
			Book[] books = new Book[] { math, new Book("Physics", 44), philosophy};
			Library lib = new Library("State Library", books);

			Console.WriteLine("Getting Biggest Book: ");
			CheckBook(lib.GetBiggestBook());

			Console.WriteLine("\nGetting Philosophy Book: ");
			CheckBook(lib.GetBook("Philosophy"));

			Console.WriteLine();
			Console.WriteLine(lib);
			Console.WriteLine();

			lib.DeleteBook(math);

			Console.WriteLine("Getting Math Book: ");
			CheckBook(lib.GetBook("Math"));

			Console.WriteLine("\nGetting Biggest Book: ");
			CheckBook(lib.GetBiggestBook());
		}
	}
}
