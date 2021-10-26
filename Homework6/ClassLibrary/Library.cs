using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary
{
	public class Library
	{
		List<Book> books = new List<Book>();
		public string Name { get; private set; }
		public Book BiggestBook { get; private set; }
		public Library(string name)
		{
			Name = name;
		}
		public Library(string name, params Book[] books) : this(name)
		{
			this.books = books.ToList();
			foreach(var book in this.books) {
				book.LibraryName = Name;
				if (BiggestBook == null || BiggestBook.PageAmount < book.PageAmount) {
					BiggestBook = book;
				}
			}
		}
		public void AddBooks(params Book[] books)
		{
			foreach(var book in books) {
				if (BiggestBook == null || BiggestBook.PageAmount < book.PageAmount) {
					BiggestBook = book;
				}
				book.LibraryName = Name;
			}
			this.books.AddRange(books);
		}
		public Book GetBook(int index)
		{
			return (index < books.Count)? books[index] : null;
		}
		public Book GetBook(string bookName)
		{
			foreach(var book in books) {
				if (book.Name == bookName)
					return book;
			}
			return null;
		}
		public void DeleteBook(string name)
		{
			DeleteBook(GetBook(name));
		}
		public void DeleteBook(int index)
		{
			DeleteBook(GetBook(index));
		}
		public void DeleteBook(Book book)
		{
			if (books.Contains(book)) {
				book.LibraryName = "";
				books.Remove(book);

				if (BiggestBook == book) {
					BiggestBook = books[0];
					for(int i = 1; i < books.Count; i++) {
						if (books[i].PageAmount > BiggestBook.PageAmount) {
							BiggestBook = books[i];
						}
					}
				}
			}
		}
		public void DumpBooks()
		{
			foreach(var book in books) {
				book.LibraryName = "";
			}
			books.Clear();
			BiggestBook = null;
		}
		public override string ToString()
		{
			string result = $"====== Library: {Name} ======\n";
			foreach(var book in books) {
				result += '\n' + book.ToString() + "\n-----------------";
			}
			return result;
		}
	}	
}