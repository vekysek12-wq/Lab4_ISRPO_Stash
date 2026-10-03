using System;
class Program {
    static void Main() {
        Console.WriteLine("=== Лабораторная работа №4 ===");
        Console.WriteLine("Добро пожаловать!");
        string fio = "Сташенко Дмитрий Николаевич";
        Console.WriteLine($"ФИО: {fio}");

        string group = "ИС-243";
Console.WriteLine($"Группа: {group}");
        Console.WriteLine($"Дата и время: {DateTime.Now}");
Console.WriteLine("Меню:");
                Console.WriteLine("1 — Показать ФИО");
                Console.WriteLine("2 — Показать группу");
                Console.WriteLine("3 — Показать дату");
                Console.WriteLine("4 — Выход");
                Console.Write("Ваш выбор: ");

    }
}