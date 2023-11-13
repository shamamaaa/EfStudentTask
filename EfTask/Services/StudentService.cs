using System;
using EfTask.DAL;
using EfTask.Exceptions;
using EfTask.Models;

namespace EfTask.Services
{
	public class StudentService
	{
		AppDbContext _context = new AppDbContext();


        public void CreateStudent(Student student)
		{
			_context.Students.Add(student);
			_context.SaveChanges();
		}

        public Student GetStudentById(int id)
        {
            Student student = _context.Students.Find(id);

            if (student!=null)
            {
                return student;
            }
            else
            {
                throw new StudentNotFound();
            }
        }

        public void DeleteStudent(int id)
        {
            Student student = GetStudentById(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
            else
            {
                throw new StudentNotFound();
            }
        }

        public List<Student> GetAllStudent()
        {
            List<Student> Students = _context.Students.ToList();
            return Students;
        }


    }
}

