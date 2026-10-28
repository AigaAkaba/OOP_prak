using System;

namespace ObjectArraysApp
{
    // Клас Rectangle для загального завдання
    class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double GetArea()
        {
            return Width * Height;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Прямокутник [Ширина: {Width}, Висота: {Height}] -> Площа: {GetArea():F2}");
        }
    }

    // Клас Student для домашнього завдання
    class Student
    {
        public string Name { get; set; }
        public double AverageGrade { get; set; }

        public Student(string name, double averageGrade)
        {
            Name = name;
            AverageGrade = averageGrade;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Студент: {Name,-10} | Середній бал: {AverageGrade}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Налаштування кодування для коректного виводу кирилиці
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== ПРАКТИЧНА РОБОТА № 8: МАСИВИ ОБ'ЄКТІВ КОРИСТУВАЧА ===\n");

            // --- ЗАГАЛЬНЕ ЗАВДАННЯ ---
            Console.WriteLine("1. Пошук прямокутника з найбільшою площею у масиві з 5 елементів:");
            Rectangle[] rectangles = new Rectangle[5];
            
            // Ініціалізація елементів масиву через оператор new у циклі
            Random rand = new Random();
            for (int i = 0; i < rectangles.Length; i++)
            {
                rectangles[i] = new Rectangle(rand.Next(1, 10) + rand.NextDouble(), rand.Next(1, 10) + rand.NextDouble());
                Console.Write($"  Елемент #{i + 1}: ");
                rectangles[i].PrintInfo();
            }

            // Пошук прямокутника з найбільшою площею
            Rectangle maxRectangle = rectangles[0];
            for (int i = 1; i < rectangles.Length; i++)
            {
                if (rectangles[i].GetArea() > maxRectangle.GetArea())
                {
                    maxRectangle = rectangles[i];
                }
            }

            Console.WriteLine("\nРезультат пошуку:");
            Console.Write("  Найбільший ");
            maxRectangle.PrintInfo();


            // --- ДОМАШНЄ ЗАВДАННЯ ---
            Console.WriteLine("\n=== ДОМАШНЄ ЗАВДАННЯ (Сортування студентів за середнім балом) ===");
            
            Student[] students = new Student[]
            {
                new Student("Олександр", 9.2),
                new Student("Софія", 11.5),
                new Student("Максим", 8.4),
                new Student("Анастасія", 10.9),
                new Student("Дмитро", 7.8)
            };

            Console.WriteLine("До сортування:");
            foreach (var student in students)
            {
                student.PrintInfo();
            }

            // Сортування масиву студентів за середнім балом у порядку спадання (Bubble Sort або LINQ)
            // Використаємо класичний алгоритм бульбашкового сортування за спаданням
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = 0; j < students.Length - i - 1; j++)
                {
                    if (students[j].AverageGrade < students[j + 1].AverageGrade)
                    {
                        // Обмін місцями
                        Student temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nПісля сортування за спаданням балу:");
            foreach (var student in students)
            {
                student.PrintInfo();
            }
        }
    }
}