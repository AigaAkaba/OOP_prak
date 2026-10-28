using System;
using System.Text;

// ===== Класи =====
class Weapon
{
    public string Name;
    public int Damage;
    public ConsoleColor Color;

    public Weapon(string name, int damage, ConsoleColor color)
    {
        Name = name;
        Damage = damage;
        Color = color;
    }
}

class Hero
{
    public string Name;
    public Weapon Weapon;

    public Hero(string name, Weapon weapon)
    {
        Name = name;
        Weapon = weapon;
    }
}

class Dummy
{
    public int Hp = 100;
}

// ===== Програма =====
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        // 1. Запит імені
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Введіть ім'я героя: ");
        string name = Console.ReadLine();

        // 2. Вибір зброї
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Оберіть зброю: 1 - Меч, 2 - Лук, 3 - Посох");

        Weapon weapon = null;
        while (weapon == null)
        {
            string choice = Console.ReadLine();

            if (choice == "1") weapon = new Weapon("Меч", 15, ConsoleColor.Cyan);
            else if (choice == "2") weapon = new Weapon("Лук", 12, ConsoleColor.Green);
            else if (choice == "3") weapon = new Weapon("Посох", 18, ConsoleColor.Magenta);
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неправильний вибір, введіть 1, 2 або 3:");
            }
        }

        Hero hero = new Hero(name, weapon);
        Dummy dummy = new Dummy();
        Random rnd = new Random();

        // 3. Бій
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"\n{hero.Name} вирушає в бій зі зброєю: {hero.Weapon.Name}!\n");

        int round = 1;
        while (dummy.Hp > 0)
        {
            int damage = hero.Weapon.Damage + rnd.Next(0, 6);
            dummy.Hp -= damage;
            if (dummy.Hp < 0) dummy.Hp = 0;

            Console.ForegroundColor = hero.Weapon.Color;
            Console.WriteLine($"Раунд {round}: {hero.Name} завдає {damage} шкоди!");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"   HP манекена: {dummy.Hp}");

            round++;
        }

        // 4. Перемога
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nПеремога! {hero.Name} знищив манекена за {round - 1} раундів!");

        Console.ResetColor();
    }
}