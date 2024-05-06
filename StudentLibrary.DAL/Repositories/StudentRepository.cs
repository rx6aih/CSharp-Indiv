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
	public class StudentRepository : IRepository<Student>
	{
		private Context db;
		public StudentRepository(Context db)
		{
			this.db = db;
		}
		public IEnumerable<Student> GetAll()
		{
			return db.Students;
		}
		public void Create(Student student)
		{
			db.Students.Add(student);
		}

		public Student Get(int id)
		{
			return db.Students.Find(id);
		}

		public void Update(Student student)
		{
			db.Entry(student).State = EntityState.Modified;
		}

		public void Delete(int id)
		{
			Student student = db.Students.Find(id);
			if (student != null)
			{
				db.Students.Remove(student);
			}
		}

		public IEnumerable<Student> Find(Func<Student, bool> predicate)
		{
			return db.Students.Where(predicate).ToList();
		}
	}
}
