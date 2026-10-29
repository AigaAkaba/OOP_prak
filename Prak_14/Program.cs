using System;

namespace AbstractClassesApp
{
    // Абстрактний базовий клас Shape
    abstract class Shape
    {
        // Абстрактні методи (без тіла, обов'язкові для реалізації в похідних класах)
        public abstract double GetArea();
        
        // Домашнє завдання: додано абстрактний метод GetPerimeter()
        public abstract double GetPerimeter();

        // Звичайний метод, який може містити реалізацію
        public void PrintInfo()
        {
            Console.WriteLine($"Фігура: {GetType().Name}");
            Console.WriteLine($"Площа: {GetArea():F2}");
            Console.WriteLine($"Периметр: {GetPerimeter():F2}");
            Console.WriteLine(new string('-', 30));
        }
    }

    // Похідний клас Circle
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        // Реалізація абстрактного методу для площі кола (S = π * r²)
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        // Реалізація абстрактного методу для периметра (довжини кола: P = 2 * π * r)
        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    // Похідний клас Rectangle
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Реалізація абстрактного методу для площі прямокутника (S = w * h)
        public override double GetArea()
        {
            return Width * Height;
        }

        // Реалізація абстрактного методу для периметра (P = 2 * (w + h))
        public override double GetPerimeter()
        {
            return 2 * (Width + Height);
        }
    }

    // Похідний клас Triangle
    class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        // Реалізація периметра трикутника (P = a + b + c)
        public override double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }

        // Реалізація площі трикутника за формулою Герона
        public override double GetArea()
        {
            double p = GetPerimeter() / 2; // Півпериметр
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Налаштування кодування для коректного виводу кирилиці
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== ПРАКТИЧНА РОБОТА № 14: АБСТРАКТНІ КЛАСИ ТА МЕТОДИ ===\n");

            // Загальне завдання: Перевірка заборони створення об'єкта абстрактного класу
            // Спроба розкоментувати наступну строчку викликає помилку компіляції CS0144:
            // Shape directShape = new Shape(); // Cannot create an instance of the abstract type or interface 'Shape'

            Console.WriteLine("1. Створення об'єктів конкретних дочірніх класів через абстрактні посилання:\n");

            Shape[] shapes = new Shape[]
            {
                new Circle(5.0),
                new Rectangle(4.0, 6.0),
                new Triangle(3.0, 4.0, 5.0)
            };

            foreach (Shape shape in shapes)
            {
                shape.PrintInfo();
            }
        }
    }
}