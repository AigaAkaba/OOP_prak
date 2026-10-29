using System;

namespace OperatorOverloadingApp
{
    // Модернізований клас Point для перевантаження операторів
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        // Загальне завдання 1: Перевантаження бінарного оператора '+'
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        // Загальне завдання 2: Перевантаження операторів порівняння '==' та '!=' (обов'язково парой)
        public static bool operator ==(Point p1, Point p2)
        {
            if (ReferenceEquals(p1, p2)) return true;
            if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null)) return false;
            return p1.X == p2.X && p1.Y == p2.Y;
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }

        // Домашнє завдання: Перевантаження оператора '*' для множення координат точки на скалярне число
        public static Point operator *(Point p, double scalar)
        {
            return new Point(p.X * scalar, p.Y * scalar);
        }

        // Симетричне множення (скаляр * точка)
        public static Point operator *(double scalar, Point p)
        {
            return new Point(p.X * scalar, p.Y * scalar);
        }

        // Перевизначення Equals та GetHashCode для уникнення попереджень компілятора при перевантаженні '=='
        public override bool Equals(object obj)
        {
            if (obj is Point other)
            {
                return X == other.X && Y == other.Y;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Точка: ({X}, {Y})");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Налаштування кодування для коректного виводу кирилиці
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== ПРАКТИЧНА РОБОТА № 9: ПЕРЕВАНТАЖЕННЯ ОПЕРАТОРІВ ===\n");

            // Створення тестових точок
            Point p1 = new Point(2.0, 3.0);
            Point p2 = new Point(4.0, 5.0);

            Console.Write("Початкова точка 1: ");
            p1.PrintInfo();
            Console.Write("Початкова точка 2: ");
            p2.PrintInfo();

            // Тест оператора '+' (Загальне завдання)
            Point p3 = p1 + p2;
            Console.Write("\nРезультат додавання (p1 + p2): ");
            p3.PrintInfo();

            // Тест операторів '==' та '!=' (Загальне завдання)
            Point p4 = new Point(2.0, 3.0);
            Console.WriteLine($"\nПорівняння p1 та p4 (p1 == p4): {p1 == p4}");
            Console.WriteLine($"Порівняння p1 та p2 (p1 != p2): {p1 != p2}");

            // Тест оператора '*' з числом (Домашнє завдання)
            double scalar = 3.0;
            Point p5 = p1 * scalar;
            Console.WriteLine($"\n=== ДОМАШНЄ ЗАВДАННЯ ===");
            Console.Write($"Результат множення точки p1 на скаляр {scalar} (p1 * {scalar}): ");
            p5.PrintInfo();
        }
    }
}