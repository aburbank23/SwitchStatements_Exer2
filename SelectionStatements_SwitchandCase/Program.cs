using System;

namespace SelectionStatements_SwitchandCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi {userName}! I have a favorite animal.");
            Console.WriteLine($"Is it a pig, a tiger, or Dolly?");

            var userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case "pig":
                    Console.WriteLine("No, it's not a pig.");
                    break;
                    

            }
        }
    }
}
