using System;

namespace SafeCastApp
{
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius) => Radius = radius;

        public override double GetArea() => Math.PI * Radius * Radius;

        // Специфічний метод, якого немає у базовому класі Shape
        public void ChangeRadius(double newRadius)
        {
            Radius = newRadius;
            Console.WriteLine($"Радіус кола успішно змінено на: {Radius}");
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height) { Width = width; Height = height; }

        public override double GetArea() => Width * Height;
    }

    class Program
    {
        // Домашнє завдання: метод приймає object та виводить інформацію про його клас
        static void CheckObjectType(object obj)
        {
            if (obj == null)
            {
                Console.WriteLine("Передано об'єкт null.");
                return;
            }

            if (obj is Circle c)
            {
                Console.WriteLine($"[Object Check] Це екземпляр класу Circle з радіусом: {c.Radius}");
            }
            else if (obj is Rectangle r)
            {
                Console.WriteLine($"[Object Check] Це екземпляр класу Rectangle з розмірами: {r.Width}x{r.Height}");
            }
            else
            {
                Console.WriteLine($"[Object Check] Це екземпляр іншого класу: {obj.GetType().Name}");
            }
        }

        static void Main(string[] args)
        {
            // Налаштування кодування для коректного виводу кирилиці
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== ПРАКТИЧНА РОБОТА № 16: ОПЕРАТОРИ IS ТА AS ===\n");

            // Загальне завдання: масив Shape[] з різними фігурами
            Shape[] shapes = new Shape[]
            {
                new Circle(3.0),
                new Rectangle(4.0, 5.0),
                new Circle(6.5)
            };

            Console.WriteLine("1. Обхід масиву Shape[] та безпечне приведення через оператор 'as':");
            for (int i = 0; i < shapes.Length; i++)
            {
                // Використання оператора 'as' для безпечного приведення до Circle
                Circle circle = shapes[i] as Circle;

                if (circle != null)
                {
                    Console.Write($"  Елемент #{i + 1}: Знайдено об'єкт типу Circle. ");
                    circle.ChangeRadius(8.0); // Виклик специфічного методу
                }
                else
                {
                    Console.WriteLine($"  Елемент #{i + 1}: Це інша фігура (не коло).");
                }
            }

            // Домашнє завдання: тестування методу визначення типу об'єкта
            Console.WriteLine("\n=== ДОМАШНЄ ЗАВДАННЯ ===");
            CheckObjectType(new Circle(12.0));
            CheckObjectType(new Rectangle(7.0, 3.0));
            CheckObjectType("Тестовий рядок");
        }
    }
}