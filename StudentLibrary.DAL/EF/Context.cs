using Microsoft.EntityFrameworkCore;
using StudentLibrary.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.DAL.EF
{
	public class Context : DbContext
	{
		public Context()
		{
			Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseNpgsql(@"host=localhost;port=5432;database=student-book;UserId=postgres;password=1957");
		}


		public DbSet<Book> Books { get; set; }
		public DbSet<Student> Students { get; set; }
		public DbSet<StudentBook> StudentBooks { get; set; }
		public DbSet<University> Universities { get; set; }
	}
}
