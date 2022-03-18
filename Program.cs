using System;
namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Врата Дарина. Молви друг и входи.");
            string userPIN = Console.ReadLine();
            if (userPIN == "Мелон")
            {
                Console.WriteLine("Как тебя зовут, друг?");
                string userNAME = Console.ReadLine();
                Console.WriteLine($"Проходи же, {userNAME}!");

            }
            else
            {
            Console.WriteLine("Ты не пройдёшь!");
            }

        }
    }
}