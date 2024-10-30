using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testplatformunew
{
 
    
        public class StudentPanel
        {
            private StudentController studentController = new StudentController();

          
            public void Start()
            {
                if (Login())
                {
                    ShowStudentOptions();
                }
                else
                {
                    Console.WriteLine("Giriş başarısız.");
                }
            }

           
            private bool Login()
            {
                Console.Write("Öğrenci Email: ");
                string email = Console.ReadLine();
                Console.Write("Şifre: ");
                string password = Console.ReadLine();

                return studentController.Login(email, password);
            }

           
            private void ShowStudentOptions()
            {
                Console.WriteLine("\nSınava Girmek için 1'e basın:");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    ConductExam();
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim.");
                }
            }

          
            private void ConductExam()
            {
                List<Question> questions = studentController.GetRandomQuestions();
                int correctAnswers = 0;

                Console.WriteLine("\nSınav Başladı:");
                foreach (var question in questions)
                {
                    Console.WriteLine(question.Text);
                    Console.Write("Cevap: ");
                    string answer = Console.ReadLine();

                    if (answer == question.CorrectAnswer)
                    {
                        correctAnswers++;
                    }
                }

                Console.WriteLine($"Sınav Sonucu: {correctAnswers}/{questions.Count} doğru.");
            }
        }
    }

