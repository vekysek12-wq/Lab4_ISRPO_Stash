using System;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Лабораторная работа №4 ===");
            Console.WriteLine("Добро пожаловать в консольное приложение!\n");

            string fio = "Сташенко Дмитрий Николаевич";
            string group = "ИС-243";

            bool running = true;
            while (running)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1 — Показать ФИО");
                Console.WriteLine("2 — Показать группу");
                Console.WriteLine("3 — Показать дату");
                Console.WriteLine("4 — Выход");
                Console.Write("Ваш выбор: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"ФИО: {fio}\n");
                        break;
                    case "2":
                        Console.WriteLine($"Группа: {group}\n");
                        break;
                    case "3":
                        Console.WriteLine($"Дата и время: {DateTime.Now}\n");
                        break;
                    case "4":
                        Console.WriteLine("Выход из программы. До свидания!");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.\n");
                        break;
                }
            }
        }
    }
}
