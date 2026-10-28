using System;

namespace EncapsulationApp
{
    // Клас Circle з інкапсуляцією та властивістю Radius
    class Circle
    {
        // Приховане поле захисту (backing field)
        private double radius;

        // Властивість Radius із логікою перевірки у блоці set
        public double Radius
        {
            get { return radius; }
            set 
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    Console.WriteLine($"[Помилка] Спроба встановити некоректний радіус ({value}). Значення не змінено.");
                }
            }
        }

        // Конструктор
        public Circle(double initialRadius)
        {
            Radius = initialRadius; // Використовує властивість для перевірки
        }

        // Методи обчислення характеристик
        public double GetArea() => Math.PI * radius * radius;
        public double GetCircumference() => 2 * Math.PI * radius;

        public void PrintInfo()
        {
            Console.WriteLine($"Радіус кола: {Radius}");
            Console.WriteLine($"Площа: {GetArea():F2}");
            Console.WriteLine($"Довжина: {GetCircumference():F2}");
            Console.WriteLine(new string('-', 30));
        }
    }

    // Домашнє завдання: клас Student з авто-властивостями та перевіркою віку
    class Student
    {
        // Автоматичні властивості для імені та групи
        public string Name { get; set; }
        public string Group { get; set; }

        // Повноструктурна властивість для перевірки віку
        private int age;
        public int Age
        {
            get { return age; }
            set 
            {
                if (value >= 16 && value <= 100)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine($"[Помилка] Некоректний вік студента ({value}). Вік не змінено.");
                }
            }
        }

        public void PrintStudentInfo()
        {
            Console.WriteLine($"Студент: {Name}, Група: {Group}, Вік: {Age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Налаштування кодування для коректного виводу кирилиці
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== ПРАКТИЧНА РОБОТА № 6: ІНКАПСУЛЯЦІЯ ТА ВЛАСТИВОСТІ ===\n");

            // Загальне завдання: тестування класу Circle з інкапсуляцією
            Console.WriteLine("1. Робота з класом Circle:");
            Circle myCircle = new Circle(5.0);
            myCircle.PrintInfo();

            // Спроба встановити коректне нове значення
            Console.WriteLine("Змінюємо радіус на 10.5:");
            myCircle.Radius = 10.5;
            myCircle.PrintInfo();

            // Спроба встановити некоректне значення (менше або дорівнює нулю)
            Console.WriteLine("Спроба встановити від'ємний радіус (-3.0):");
            myCircle.Radius = -3.0;
            myCircle.PrintInfo(); // Радіус повинен залишитися 10.5

            // Домашнє завдання: тестування класу Student
            Console.WriteLine("\n=== ДОМАШНЄ ЗАВДАННЯ (Клас Student) ===");
            Student student = new Student();
            student.Name = "Олександр";
            student.Group = "КН-21";
            student.Age = 18; // Коректний вік
            student.PrintStudentInfo();

            // Спроба задати некоректний вік
            Console.WriteLine("\nСпроба встановити неприпустимий вік (12):");
            student.Age = 12;
            student.PrintStudentInfo();
        }
    }
}