using System;

namespace IJunior_HomeWork_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string zodiacSign;
            string work;

            Console.WriteLine("Добрый день! Как вас зовут ?");
            name = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Какой ваш знак зодиака");
            zodiacSign = Console.ReadLine();
            Console.WriteLine("Где вы работете?");
            work= Console.ReadLine();

            Console.WriteLine($"Вас зовут {name}. Вам {age} лет. Ваш знак зодиака {zodiacSign}. Ваша работа {work}");
        }
    }
}
