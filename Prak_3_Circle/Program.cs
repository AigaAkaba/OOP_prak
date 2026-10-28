using System;

namespace CircleApp
{
    // Клас Circle для обчислення характеристик кола
    class Circle
    {
        // Відкрите поле для збереження радіуса
        public double Radius;

        // Метод для обчислення площі кола (S = π * r²)
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        // Метод для обчислення довжини кола (C = 2 * π * r)
        public double GetCircumference()
        {
            return 2 * Math.PI * Radius;
        }

        // Домашнє завдання: метод, який збільшує радіус кола у задану кількість разів
        public void MultiplyRadius(double factor)
        {
            if (factor > 0)
            {
                Radius *= factor;
                Console.WriteLine($"\nРадіус успішно збільшено в {factor} разів! Новий радіус: {Radius}");
            }
            else
            {
                Console.WriteLine("\nМножник має бути більшим за 0!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Налаштування кодування для відображення українських літер
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== ПРАКТИЧНА РОБОТА № 3: КЛАС \"КОЛО\" ===");

            // Створення об'єкта класу Circle
            Circle myCircle = new Circle();

            // Введення радіуса з клавіатури
            Console.Write("Введіть радіус кола: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double userRadius) && userRadius > 0)
            {
                myCircle.Radius = userRadius;

                // Загальне завдання: виведення площі та довжини кола
                Console.WriteLine($"\n--- Результати для радіуса r = {myCircle.Radius} ---");
                Console.WriteLine($"Площа кола (GetArea): {myCircle.GetArea():F2}");
                Console.WriteLine($"Довжина кола (GetCircumference): {myCircle.GetCircumference():F2}");

                // Домашнє завдання: збільшення радіуса у задану кількість разів
                Console.WriteLine("\n=== ДОМАШНЄ ЗАВДАННЯ ===");
                Console.Write("Введіть коефіцієнт збільшення радіуса (наприклад, 2, 3, 5): ");
                
                if (double.TryParse(Console.ReadLine(), out double factor))
                {
                    myCircle.MultiplyRadius(factor);

                    // Повторний розрахунок характеристик з новим радіусом
                    Console.WriteLine($"Нова площа кола: {myCircle.GetArea():F2}");
                    Console.WriteLine($"Нова довжина кола: {myCircle.GetCircumference():F2}");
                }
                else
                {
                    Console.WriteLine("Некоректний коефіцієнт!");
                }
            }
            else
            {
                Console.WriteLine("Помилка: Введено некоректне значення радіуса!");
            }
        }
    }
}