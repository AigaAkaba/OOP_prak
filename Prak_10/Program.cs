using System;

namespace InheritanceApp
{
    // Базовий клас Person
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Ім'я: {Name}, Вік: {Age}");
        }
    }

    // Похідний клас Student (Загальне завдання)
    class Student : Person
    {
        public string Faculty { get; set; }
        public int Course { get; set; }

        public Student(string name, int age, string faculty, int course) 
            : base(name, age) // Передача параметрів у конструктор базового класу
        {
            Faculty = faculty;
            Course = course;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Студент — Ім'я: {Name}, Вік: {Age}, Факультет: {Faculty}, Курс: {Course}");
        }
    }

    // Похідний клас Teacher (Домашнє завдання)
    class Teacher : Person
    {
        public string Department { get; set; }
        public decimal Salary { get; set; }

        public Teacher(string name, int age, string department, decimal salary) 
            : base(name, age) // Передача параметрів у конструктор базового класу
        {
            Department = department;
            Salary = salary;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Викладач — Ім'я: {Name}, Вік: {Age}, Кафедра: {Department}, Зарплата: {Salary} грн");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Налаштування кодування для коректного виводу кирилиці
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== ПРАКТИЧНА РОБОТА № 10: МЕХАНІЗМ СПАДКУВАННЯ ===\n");

            // Створення об'єкта базового класу
            Person person = new Person("Олексій", 45);
            Console.WriteLine("Базовий клас Person:");
            person.PrintInfo();

            // Створення об'єкта похідного класу Student (Загальне завдання)
            Student student = new Student("Максим", 19, "Комп'ютерні науки", 2);
            Console.WriteLine("\nПохідний клас Student (Загальне завдання):");
            student.PrintInfo();

            // Створення об'єкта похідного класу Teacher (Домашнє завдання)
            Teacher teacher = new Teacher("Світлана Іванівна", 38, "Програмної інженерії", 27000.00m);
            Console.WriteLine("\nПохідний клас Teacher (Домашнє завдання):");
            teacher.PrintInfo();
        }
    }
}