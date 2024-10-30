using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testplatformunew
{
    public class StudentController
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(string name, string surname, string email, string password)
        {
            var student = new Student
            {
                Name = name,
                Surname = surname,
                Email = email,
                Password = password
            };
            students.Add(student);
        }

        // Login metodu
        public bool Login(string email, string password)
        {
            foreach (var student in students)
            {
                if (student.Email == email && student.Password == password)
                {
                    Console.WriteLine("Giriş başarılı!");
                    return true;
                }
            }

            Console.WriteLine("Giriş başarısız.");
            return false;
        }

        internal List<Question> GetRandomQuestions()
        {
            throw new NotImplementedException();
        }
    }

}