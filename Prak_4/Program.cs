using System;

namespace RectangleApp
{
    // Клас Rectangle для моделювання прямокутника
    class Rectangle
    {
        // Поля для ширини та висоти
        public double Width;
        public double Height;

        // Метод для обчислення площі прямокутника (S = width * height)
        public double GetArea()
        {
            return Width * Height;
        }

        // Метод для обчислення периметра прямокутника (P = 2 * (width + height))
        public double GetPerimeter()
        {
            return 2 * (Width + Height);
        }

        // Домашнє завдання: логічний метод, який визначає, чи є цей прямокутник квадратом
        public bool IsSquare()
        {
            return Width == Height;
        }

        // Допоміжний метод для виведення інформації про прямокутник
        public void PrintInfo()
        {
            Console.WriteLine($"Ширина: {Width}, Висота: {Height}");
            Console.WriteLine($"Площа: {GetArea():F2}");
            Console.WriteLine($"Периметр: {GetPerimeter():F2}");
            
            if (IsSquare())
            {
                Console.WriteLine("Статус: Цей прямокутник є КВАДРАТОМ.");
            }
            else
            {
                Console.WriteLine("Статус: Це звичайний прямокутник.");
            }
            Console.WriteLine(new string('-', 30));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Налаштування кодування для коректного виводу кирилиці
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== ПРАКТИЧНА РОБОТА № 4: КЛАС \"ПРЯМОКУТНИК\" ===\n");

            // Загальне завдання: створення масиву з двох прямокутників
            Rectangle[] rectangles = new Rectangle[2];

            // Ініціалізація першого прямокутника (звичайний прямокутник)
            rectangles[0] = new Rectangle();
            rectangles[0].Width = 4.5;
            rectangles[0].Height = 8.0;

            // Ініціалізація другого прямокутника (квадрат для перевірки ДЗ)
            rectangles[1] = new Rectangle();
            rectangles[1].Width = 6.0;
            rectangles[1].Height = 6.0;

            // Виведення параметрів кожного прямокутника з масиву
            for (int i = 0; i < rectangles.Length; i++)
            {
                Console.WriteLine($"Прямокутник №{i + 1}:");
                rectangles[i].PrintInfo();
            }
        }
    }
}