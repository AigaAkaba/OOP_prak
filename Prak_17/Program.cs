using System;

namespace SealedModifierApp
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Малювання базової фігури.");
        }
    }

    // Загальне завдання: Клас Rectangle оголошено як sealed
    sealed class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override void Draw()
        {
            Console.WriteLine($"Малювання прямокутника зі сторонами {Width}x{Height}.");
        }
    }

    /* 
     * ЗАГАЛЬНЕ ЗАВДАННЯ (Аналіз помилки компіляції):
     * Якщо спробувати створити клас Square, який успадковує sealed-клас Rectangle:
     * 
     * class Square : Rectangle // Помилка CS0509: "Square": неможливо успадкувати від запечатаного типу "Rectangle"
     * {
     *     public Square(double side) : base(side, side) { }
     * }
     */

    // Домашнє завдання: Ланцюжок з трьох класів для дослідження запечатаного методу
    class FirstClass
    {
        public virtual void Display()
        {
            Console.WriteLine("FirstClass: базовий метод Display");
        }
    }

    class SecondClass : FirstClass
    {
        // Метод перевизначено та запечатано за допомогою sealed override
        public sealed override void Display()
        {
            Console.WriteLine("SecondClass: запечатаний метод Display");
        }
    }

    class ThirdClass : SecondClass
    {
        /* 
         * ДОМАШНЄ ЗАВДАННЯ (Аналіз помилки компіляції):
         * Спроба перевизначити запечатаний метод у третьому класі:
         * 
         * public override void Display() // Помилка CS0238: "ThirdClass.Display()": неможливо перевизначити запечатаний член "SecondClass.Display()"
         * {
         *     Console.WriteLine("ThirdClass");
         * }
         */
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Налаштування кодування для коректного виводу кирилиці
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== ПРАКТИЧНА РОБОТА № 17: МОДИФІКАТОР SEALED ===\n");

            // Перевірка роботи sealed-класу
            Rectangle rect = new Rectangle(4.0, 7.0);
            rect.Draw();

            // Перевірка роботи sealed-методу в ланцюжку класів
            Console.WriteLine("\nВиклик запечатаного методу через об'єкт другого класу:");
            FirstClass obj = new SecondClass();
            obj.Display();
        }
    }
}