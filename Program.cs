using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1, 101);

            Console.WriteLine("Guess the number (1-100): ");
            int input = int.Parse(Console.ReadLine());

            while (input != number)
            {
                if (input < number)
                {
                    Console.WriteLine("Too low!");
                }
                else if (input > number)
                {
                    Console.WriteLine("Too high!");
                }

                Console.WriteLine("Guess the number (1-100): ");
                input = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("You guessed it!");
            Console.ReadKey();
        }
    }
}
