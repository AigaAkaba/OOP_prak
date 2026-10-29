using System;

namespace MethodHidingApp
{
    // Базовий клас Vehicle
    class Vehicle
    {
        // Захищене поле швидкості (доступне в базовому та похідних класах)
        protected double speed;

        public Vehicle(double speed)
        {
            this.speed = speed;
        }

        // Метод Start базового класу
        public void Start()
        {
            Console.WriteLine($"[Vehicle] Транспортний засіб починає рух зі швидкістю {speed} км/год.");
        }
    }

    // Похідний клас Car (Загальне завдання)
    class Car : Vehicle
    {
        public string Model { get; set; }

        public Car(string model, double speed) : base(speed)
        {
            Model = model;
        }

        // Заміщення методу базового класу за допомогою ключового слова 'new'
        public new void Start()
        {
            Console.WriteLine($"[Car] Автомобіль '{Model}' заводить двигун і плавно рушає зі швидкістю {speed} км/год.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Налаштування кодування для коректного виводу кирилиці
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== ПРАКТИЧНА РОБОТА № 12: PROTECTED ТА ЗАМІЩЕННЯ МЕТОДІВ ===\n");

            // 1. Створення екземпляра класу Car та виклик його методу
            Car myCar = new Car("Toyota", 90.0);
            Console.WriteLine("Виклик методу Start() через посилання на тип Car:");
            myCar.Start(); // Викличеться метод з класу Car

            // 2. Домашнє завдання: виклик заміщеного методу через посилання на базовий клас (Vehicle)
            Console.WriteLine("\n=== ДОМАШНЄ ЗАВДАННЯ (Виклик через базове посилання) ===");
            
            // Зберігаємо об'єкт Car у змінну типу Vehicle
            Vehicle baseVehicleRef = myCar;
            
            Console.WriteLine("Виклик методу Start() через посилання типу Vehicle (статичне зв'язування):");
            baseVehicleRef.Start(); // Викличеться метод з класу Vehicle через відсутність поліморфізму (використано new, а не override)
        }
    }
}