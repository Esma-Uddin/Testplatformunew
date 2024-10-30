using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testplatformunew
{
   
        public class AdminPanel
        {
            private AdminController adminController = new AdminController();

         
            public void Start()
            {
                if (Login())
                {
                    ShowPanel();
                }
                else
                {
                    Console.WriteLine("Password is not correct! Back to the menu");
                }
            adminPanelStart:
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Start();

        }

            private bool Login()
            {
                Console.Write("Admin name: ");
                string name = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();
                return adminController.Login(name, password);
            }

           
            private void ShowPanel()
            {
                while (true)
                {
                    Console.WriteLine("\n1. Add student\n2. Add category\n3. Add question\n4. take an exam\n5. Exit");
                    Console.Write("Bir seçenek seçin: ");
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            AddStudent();
                            break;
                        case "2":
                            AddCategory();
                            break;
                        case "3":
                            AddQuestion();
                            break;
                        case "4":
                            ConductExam();
                            break;
                        case "5":
                            return;
                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                }
            }

          
            private void AddStudent()
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Surname: ");
                string surname = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();
                adminController.AddStudent(name, surname, email, password);
            }

           
            private void AddCategory()
            {
                Console.Write("Category name: ");
                string categoryName = Console.ReadLine();
                adminController.AddCategory(categoryName);
            }

          
            private void AddQuestion()
            {
                Console.Write("Question: ");
                string questionText = Console.ReadLine();
                Console.Write("Correct answer: ");
                string correctAnswer = Console.ReadLine();
                adminController.AddQuestion(questionText, correctAnswer);
            }
            string correctAnswer = "programlama dilidir";
           
            private void ConductExam()
            {
                List<Question> questions = adminController.GetQuestions();
                List<string> studentAnswers = new List<string>();

                Console.WriteLine("\nExam has started:");
                foreach (var question in questions)
                {
                    Console.WriteLine(question.Text);
                    Console.Write("Cevap: ");
                    string answer = Console.ReadLine();
                    studentAnswers.Add(answer);
                }

                int score = adminController.ConductExam(studentAnswers);
                adminController.ShowExamResult(score);
            }
        }

    }

