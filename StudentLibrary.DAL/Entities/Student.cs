using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.DAL.Entities
{
	public class Student
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string SecondName {  get; set; }
		public int Age {  get; set; }

		public int UniversityId {  get; set; }
		public University University { get; set; }
	}
}
