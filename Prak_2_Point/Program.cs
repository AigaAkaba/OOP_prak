using System;

namespace PointApp
{
    // Клас Point для моделювання точки на площині
    class Point
    {
        // Відкриті поля координат (тип double)
        public double X;
        public double Y;

        // Метод для виведення стану точки на екран
        public void PrintInfo()
        {
            Console.WriteLine($"Точка з координатами: ({X}, {Y})");
        }

        // Домашнє завдання: метод, який обнуляє координати точки (переносить її в початок координат)
        public void ResetToOrigin()
        {
            X = 0;
            Y = 0;
            Console.WriteLine("Координати точки успішно скинуто в початок координат (0, 0).");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Налаштування кодування для коректного виводу кирилиці
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== ЗАГАЛЬНЕ ЗАВДАННЯ ===");

            // 1. Створення першої точки (Квадрант I: X > 0, Y > 0)
            Point p1 = new Point();
            p1.X = 3.5;
            p1.Y = 4.2;
            Console.Write("Точка 1 (I квадрант): ");
            p1.PrintInfo();

            // 2. Створення другої точки (Квадрант II: X < 0, Y > 0)
            Point p2 = new Point();
            p2.X = -5.0;
            p2.Y = 2.8;
            Console.Write("Точка 2 (II квадрант): ");
            p2.PrintInfo();

            // 3. Створення третьої точки (Квадрант IV: X > 0, Y < 0)
            Point p3 = new Point();
            p3.X = 7.1;
            p3.Y = -6.3;
            Console.Write("Точка 3 (IV квадрант): ");
            p3.PrintInfo();

            Console.WriteLine("\n=== ДОМАШНЄ ЗАВДАННЯ ===");
            Console.WriteLine("Обнулення координат для Точки 3:");
            
            // Виклик методу обнулення координат
            p3.ResetToOrigin();
            
            // Перевірка стану точки 3 після обнулення
            Console.Write("Точка 3 після скидання: ");
            p3.PrintInfo();
        }
    }
}