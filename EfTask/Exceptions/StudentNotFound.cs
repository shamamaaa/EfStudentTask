using System;
namespace EfTask.Exceptions
{
	public class StudentNotFound : Exception
	{
		public StudentNotFound() : base("Student not found")
        {
		}
	}
}

