using Testplatformunew;
using Testplatformunew;

using System;

namespace TestPlatformu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Admin Girişi");
            Console.WriteLine("2. Öğrenci Girişi");
            Console.Write("Seçiminiz: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.Start();
            }
            else if (choice == "2")
            {
                StudentPanel studentPanel = new StudentPanel();
                studentPanel.Start();
            }
            else
            {
                Console.WriteLine("Geçersiz seçim.");
            }
        }
    }

    public class AdminPanel
    {
        public void Start()
        {
            Console.WriteLine("Admin Paneline Hoş Geldiniz.");
            // Admin işlemleri burada yapılır, örneğin soru ekleme, kategori ekleme vb.
        }

        public bool Login()
        {
            Console.Write("Admin adı: ");
            string name = Console.ReadLine();
            Console.Write("Şifre: ");
            string password = Console.ReadLine();
            // Admin giriş doğrulaması (örnek)
            return name == "admin" && password == "1234";
        }
    }
}

