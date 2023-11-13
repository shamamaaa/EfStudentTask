using EfTask.Models;
using EfTask.Services;

namespace EfTask;
class Program
{
    static void Main(string[] args)
    {

        StudentService studentService = new StudentService();

        Student student = new Student()
        {
            Name = "Shamama",
            Surname = "Guliyeva",
            AvgPoint = 95
        };

        Student student1 = new Student()
        {
            Name = "Asiman",
            Surname = "Gasimzade",
            AvgPoint = 12
        };

        Student student2 = new Student()
        {
            Name = "Sabuhi",
            Surname = "Camalzade",
            AvgPoint = 62
        };

        Student student3 = new Student()
        {
            Name = "Zuzu",
            Surname = "Rezka",
            AvgPoint = 95
        };


        //Yaratmaq

        //studentService.CreateStudent(student);
        //studentService.CreateStudent(student1);
        //studentService.CreateStudent(student2);
        //studentService.CreateStudent(student3);

        //===========================================================

        //Ekrana cixarmaq

        //List<Student> students = studentService.GetAllStudent();
        //foreach (Student A in students)
        //{
        //    Console.WriteLine($"{A.Name} {A.Surname}");
        //}

        //===========================================================

        //Id-e gore tapilma

        //Student studentfind= studentService.GetStudentById(4);
        //Console.WriteLine($"{studentfind.Name} {studentfind.Surname}");


        //===========================================================

        //Id-e gore silme

        //studentService.DeleteStudent(2);

    }
}

