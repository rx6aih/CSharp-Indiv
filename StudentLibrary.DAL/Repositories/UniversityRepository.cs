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
	public class UniversityRepository :IRepository<University>
	{
		private Context db;
		public UniversityRepository(Context db)
		{
			this.db = db;
		}
		public IEnumerable<University> GetAll()
		{
			return db.Universities;
		}
		public void Create(University university)
		{
			db.Universities.Add(university);
		}

		public University Get(int id)
		{
			return db.Universities.Find(id);
		}

		public void Update(University university)
		{
			db.Entry(university).State = EntityState.Modified;
		}

		public void Delete(int id)
		{
			University university = db.Universities.Find(id);
			if (university != null)
			{
				db.Universities.Remove(university);
			}
		}

		public IEnumerable<University> Find(Func<University, bool> predicate)
		{
			return db.Universities.Where(predicate).ToList();
		}
	}
}
