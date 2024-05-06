using StudentLibrary.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.StudentBookForm.Comparers
{
	public class StudentBookComparer : IEqualityComparer<StudentBook>
	{
		public bool Equals(StudentBook? x, StudentBook? y)
		{
			if(Object.ReferenceEquals(x, y)) return true;

			if(Object.ReferenceEquals(x,null) || Object.ReferenceEquals(y,null)) return false;

			return x.StudentId == y.StudentId;
		}

		public int GetHashCode([DisallowNull] StudentBook sb)
		{
			if (Object.ReferenceEquals(sb, null)) return 0;

			int hashProductId = sb.StudentId == null ? 0 : sb.StudentId.GetHashCode();

			int hashProductCode = sb.Id.GetHashCode();

			return hashProductId ^ hashProductCode;
		}
	}
}
