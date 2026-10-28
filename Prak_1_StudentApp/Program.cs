using System;

namespace StudentApp
{
    // Оголошення класу Student відповідно до вимог практичної та домашнього завдання
    class Student
    {
        public string Name;          // Поле для імені
        public string Group;         // Поле для групи
        public double AverageGrade;  // Поле для середнього бала (домашнє завдання)
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Встановлюємо кодування для коректного відображення української кирилиці в консолі
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Створення першого об'єкта класу Student та заповнення його даних
            Student student1 = new Student();
            student1.Name = "Олександр";
            student1.Group = "П-23";
            student1.AverageGrade = 10.8;

            // Створення другого об'єкта класу Student
            Student student2 = new Student();
            student2.Name = "Софія";
            student2.Group = "П-14";
            student2.AverageGrade = 11.2;

            // Виведення інформації про першого студента
            Console.WriteLine("=== ІНФОРМАЦІЯ ПРО СТУДЕНТІВ ===");
            Console.WriteLine($"Студент 1:");
            Console.WriteLine($"  Ім'я: {student1.Name}");
            Console.WriteLine($"  Група: {student1.Group}");
            Console.WriteLine($"  Середній бал: {student1.AverageGrade}\n");

            // Виведення інформації про другого студента
            Console.WriteLine($"Студент 2:");
            Console.WriteLine($"  Ім'я: {student2.Name}");
            Console.WriteLine($"  Група: {student2.Group}");
            Console.WriteLine($"  Середній бал: {student2.AverageGrade}");
        }
    }
}