using System;

namespace StaticMembersApp
{
    // Модернізований клас Student зі статичним лічильником створених об'єктів
    class Student
    {
        public string Name { get; set; }
        public string Group { get; set; }

        // Приховане статичне поле для підрахунку кількості створених студентів
        private static int studentCount = 0;

        // Публічна статична властивість для отримання значення лічильника
        public static int StudentCount
        {
            get { return studentCount; }
        }

        // Конструктор за замовчуванням
        public Student()
        {
            Name = "Невідомо";
            Group = "Невідома";
            studentCount++; // Збільшуємо лічильник при виділенні пам'яті під об'єкт
        }

        // Конструктор із параметрами
        public Student(string name, string group)
        {
            Name = name;
            Group = group;
            studentCount++; // Збільшуємо лічильник при виділенні пам'яті під об'єкт
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Студент: {Name}, Група: {Group}");
        }
    }

    // Домашнє завдання: утилітарний статичний клас MathUtils
    static class MathUtils
    {
        // Статичний метод для обчислення факторіала числа
        public static long CalculateFactorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Факторіал визначений лише для невід'ємних чисел.");
            }

            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Налаштування кодування для коректного виводу кирилиці
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== ПРАКТИЧНА РОБОТА № 7: СТАТИЧНІ ЧЛЕНИ КЛАСУ ===\n");

            // Загальне завдання: створення студентів і тестування лічильника
            Console.WriteLine("Створення об'єктів студентів:");
            
            Student s1 = new Student("Олександр", "КН-21");
            s1.PrintInfo();

            Student s2 = new Student("Софія", "КН-21");
            s2.PrintInfo();

            Student s3 = new Student(); // Використання конструктора за замовчуванням
            s3.PrintInfo();

            // Виведення фінального числа створених студентів через ім'я класу
            Console.WriteLine($"\nЗагальна кількість створених студентів ( Student.StudentCount ): {Student.StudentCount}");

            // Домашнє завдання: тестування статичного утилітарного класу MathUtils
            Console.WriteLine("\n=== ДОМАШНЄ ЗАВДАННЯ (Статичний клас MathUtils) ===");
            int number = 5;
            long factorialResult = MathUtils.CalculateFactorial(number);
            Console.WriteLine($"Факторіал числа {number} ({number}!) дорівнює: {factorialResult}");
        }
    }
}