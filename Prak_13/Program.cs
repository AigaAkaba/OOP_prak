using System;

namespace PolymorphismApp
{
    // Базовий клас Shape
    class Shape
    {
        // Віртуальний метод для обчислення площі
        public virtual double GetArea()
        {
            return 0.0;
        }
    }

    // Похідний клас Circle (Загальне завдання)
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        // Перевизначення віртуального методу для кола (S = π * r²)
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Похідний клас Rectangle (Загальне завдання)
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Перевизначення віртуального методу для прямокутника (S = width * height)
        public override double GetArea()
        {
            return Width * Height;
        }
    }

    // Похідний клас Triangle (Домашнє завдання)
    class Triangle : Shape
    {
        public double BaseLength { get; set; }
        public double Height { get; set; }

        public Triangle(double baseLength, double height)
        {
            BaseLength = baseLength;
            Height = height;
        }

        // Перевизначення віртуального методу для трикутника (S = 0.5 * base * height)
        public override double GetArea()
        {
            return 0.5 * BaseLength * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Налаштування кодування для коректного виводу кирилиці
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== ПРАКТИЧНА РОБОТА № 13: ПОЛІМОРФІЗМ ТА ВІРТУАЛЬНІ МЕТОДИ ===\n");

            // Демонстрація поліморфізму: масив посилань базового типу Shape, що містять різні об'єкти
            Shape[] shapes = new Shape[]
            {
                new Circle(5.0),
                new Rectangle(4.0, 5.0),
                new Triangle(6.0, 4.0) // Домашнє завдання
            };

            for (int i = 0; i < shapes.Length; i++)
            {
                string shapeName = shapes[i].GetType().Name;
                Console.WriteLine($"Фігура #{i + 1} ({shapeName}): Площа = {shapes[i].GetArea():F2}");
            }
        }
    }
}