using System;

namespace TimProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет {name}, на данный момент сейчас {DateTime.Now}");
            Console.ReadKey();
        }
    }
}
