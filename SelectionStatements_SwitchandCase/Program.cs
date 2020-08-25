using System;

namespace SelectionStatements_SwitchandCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey! What is your favorite subject in school?");
            var favSchoolSub = Console.ReadLine();

            switch (favSchoolSub.ToLower())
            {
                case "history":
                    Console.WriteLine("History is a great subject!");
                    break;
                case "science":
                    Console.WriteLine("Science is a fun thing to learn!");
                    break;
                default:
                    Console.WriteLine("I don't know of that subject... I just like history and science!");
                    break;
            }
        }
    }
}
