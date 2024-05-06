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
	public class StudentBookRepository : IRepository<StudentBook>
	{
		private Context db;
		public StudentBookRepository(Context db)
		{
			this.db = db;
		}
		public IEnumerable<StudentBook> GetAll()
		{
			return db.StudentBooks;
		}
		public void Create(StudentBook studentBook)
		{
			db.StudentBooks.Add(studentBook);
		}

		public StudentBook Get(int id)
		{
			return db.StudentBooks.Find(id);
		}

		public void Update(StudentBook studentBook)
		{
			db.Entry(studentBook).State = EntityState.Modified;
		}

		public void Delete(int id)
		{
			StudentBook studentBook = db.StudentBooks.Find(id);
			if (studentBook != null)
			{
				db.StudentBooks.Remove(studentBook);
			}
		}

		public IEnumerable<StudentBook> Find(Func<StudentBook, bool> predicate)
		{
			return db.StudentBooks.Where(predicate).ToList();
		}
	}
}
