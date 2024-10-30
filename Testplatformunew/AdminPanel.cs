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
                Console.Write("Admin adı: ");
                string name = Console.ReadLine();
                Console.Write("Şifre: ");
                string password = Console.ReadLine();
                return adminController.Login(name, password);
            }

           
            private void ShowPanel()
            {
                while (true)
                {
                    Console.WriteLine("\n1. Öğrenci Ekle\n2. Kategori Ekle\n3. Soru Ekle\n4. Sınav Yap\n5. Çıkış");
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
                            Console.WriteLine("Geçersiz seçenek.");
                            break;
                    }
                }
            }

          
            private void AddStudent()
            {
                Console.Write("Ad: ");
                string name = Console.ReadLine();
                Console.Write("Soyad: ");
                string surname = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Şifre: ");
                string password = Console.ReadLine();
                adminController.AddStudent(name, surname, email, password);
            }

           
            private void AddCategory()
            {
                Console.Write("Kategori Adı: ");
                string categoryName = Console.ReadLine();
                adminController.AddCategory(categoryName);
            }

          
            private void AddQuestion()
            {
                Console.Write("Soru metni: ");
                string questionText = Console.ReadLine();
                Console.Write("Doğru Cevap: ");
                string correctAnswer = Console.ReadLine();
                adminController.AddQuestion(questionText, correctAnswer);
            }
            string correctAnswer = "programlama dilidir";
           
            private void ConductExam()
            {
                List<Question> questions = adminController.GetQuestions();
                List<string> studentAnswers = new List<string>();

                Console.WriteLine("\nSınav Başladı:");
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

