using System;

namespace BaseKeywordApp
{
    // Базовий клас Person
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Конструктор базового класу з параметрами (Загальне завдання)
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Віртуальний метод для виведення інформації
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Ім'я: {Name}, Вік: {Age}");
        }
    }

    // Похідний клас Student
    class Student : Person
    {
        public string Faculty { get; set; }
        public int Course { get; set; }

        // Конструктор похідного класу з використанням ключового слова 'base' (Загальне завдання)
        public Student(string name, int age, string faculty, int course) : base(name, age)
        {
            Faculty = faculty;
            Course = course;
        }

        // Домашнє завдання: перевизначення методу з викликом базової версії через 'base'
        public override void PrintInfo()
        {
            // Виклик базової реалізації методу PrintInfo() з класу Person
            base.PrintInfo();
            
            // Додавання специфічної інформації дочірнього класу
            Console.WriteLine($"Факультет: {Faculty}, Курс: {Course}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Налаштування кодування для коректного виводу кирилиці
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== ПРАКТИЧНА РОБОТА № 11: ВИКЛИК КОНСТРУКТОРІВ БАЗОВИХ КЛАСІВ (BASE) ===\n");

            // Створення об'єкта класу Student із передачею параметрів через конструктор і base
            Student student = new Student("Олександр", 19, "Комп'ютерні науки", 2);

            Console.WriteLine("Інформація про студента (з викликом базового методу через base):");
            student.PrintInfo();
        }
    }
}