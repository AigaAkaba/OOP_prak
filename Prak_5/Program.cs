using System;

namespace ConstructorApp
{
    // Модернізований клас Point із конструкторами
    class Point
    {
        public double X;
        public double Y;

        // 1. Конструктор за замовчуванням (без параметрів) - ініціалізує точку в нулі
        public Point()
        {
            X = 0;
            Y = 0;
        }

        // 2. Конструктор з параметрами - приймає початкові значення координат
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        // 3. Конструктор копіювання (домашнє завдання) - приймає інший об'єкт цього ж класу
        public Point(Point other)
        {
            X = other.X;
            Y = other.Y;
        }

        // Метод для виведення інформації про точку
        public void PrintInfo()
        {
            Console.WriteLine($"Координати точки: X = {X}, Y = {Y}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Налаштування кодування для коректного виводу кирилиці
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== ПРАКТИЧНА РОБОТА № 5: КОНСТРУКТОРИ КЛАСІВ ===\n");

            // Загальне завдання: тестування створення об'єктів різними конструкторами

            // Спосіб 1: Використання конструктора без параметрів
            Console.WriteLine("1. Створення точки через конструктор за замовчуванням:");
            Point p1 = new Point();
            p1.PrintInfo();

            // Спосіб 2: Використання конструктора з параметрами
            Console.WriteLine("\n2. Створення точки через конструктор з параметрами:");
            Point p2 = new Point(4.5, 7.8);
            p2.PrintInfo();

            // Домашнє завдання: тестування конструктора копіювання
            Console.WriteLine("\n=== ДОМАШНЄ ЗАВДАННЯ ===");
            Console.WriteLine("3. Створення нової точки шляхом копіювання існуючої (p2):");
            Point p3 = new Point(p2); // Копіюємо p2 у p3
            p3.PrintInfo();
        }
    }
}