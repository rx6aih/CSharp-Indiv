using Microsoft.EntityFrameworkCore;
using StudentLibrary.DAL.EF;
using StudentLibrary.DAL.Entities;
using StudentLibrary.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.DAL.Repositories
{
	public class BookRepository : IRepository<Book>
	{
		private Context db;
		public BookRepository(Context db)
		{
			this.db = db;
		}
		public IEnumerable<Book> GetAll()
		{
			return db.Books;
		}
		public void Create(Book book)
		{
			db.Books.Add(book);
		}

		public Book Get(int id)
		{
			return db.Books.Find(id);
		}

		public void Update(Book book)
		{
			db.Entry(book).State = EntityState.Modified;
		}

		public void Delete(int id)
		{
			Book book = db.Books.Find(id);
			if (book != null)
			{
				db.Books.Remove(book);
			}
		}

		public IEnumerable<Book> Find(Func<Book, bool> predicate)
		{
			return db.Books.Where(predicate).ToList();
		}
	}
}
