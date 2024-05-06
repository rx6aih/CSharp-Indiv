using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.DAL.Entities
{
	public class StudentBook
	{
		public int Id { get; set; }
		public DateTime ExpireDate {  get; set; }
		public int StudentId {  get; set; }
		public int BookId { get; set; }


		public Student Student { get; set; }

		public Book Book { get; set; }
		public string Status { get; set; }

	}
}
