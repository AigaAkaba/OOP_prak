using System;

namespace PolymorphicCollectionsApp
{
    // Абстрактний базовий клас Shape (з попередніх занять)
    abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius) => Radius = radius;

        public override double GetArea() => Math.PI * Radius * Radius;
        public override double GetPerimeter() => 2 * Math.PI * Radius;
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height) { Width = width; Height = height; }

        public override double GetArea() => Width * Height;
        public override double GetPerimeter() => 2 * (Width + Height);
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== ПРАКТИЧНА РОБОТА № 15: ПОЛІМОРФНІ КОЛЕКЦІЇ ===\n");

            // Загальне завдання: створення масиву типу Shape[] (по 2 об'єкти Circle та Rectangle)
            Shape[] shapes = new Shape[]
            {
                new Circle(3.0),
                new Circle(5.0),
                new Rectangle(4.0, 5.0),
                new Rectangle(2.0, 3.0)
            };

            Console.WriteLine("1. Автоматичне виведення площі кожної фігури (Загальне завдання):");
            for (int i = 0; i < shapes.Length; i++)
            {
                string typeName = shapes[i].GetType().Name;
                Console.WriteLine($"Фігура #{i + 1} ({typeName}): Площа = {shapes[i].GetArea():F2}");
            }

            // Домашнє завдання: обчислення загальної суми периметрів усіх фігур у масиві
            double totalPerimeter = 0;
            foreach (Shape shape in shapes)
            {
                totalPerimeter += shape.GetPerimeter();
            }

            Console.WriteLine($"\n=== ДОМАШНЄ ЗАВДАННЯ ===");
            Console.WriteLine($"Загальна сума периметрів усіх фігур у масиві: {totalPerimeter:F2}");
        }
    }
}