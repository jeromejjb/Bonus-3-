using System;

namespace Bonus3
{
    class Program
    {
        static void Main(string[] args)
        {
            string userAnswer = "y";

            Console.WriteLine("Welcome to the Guess a Number Game!");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            while (userAnswer == "y")
            {
                Console.WriteLine("I am thinking of a number between 1 and 100.");
                Console.WriteLine("Try to guess it, n00b.");
                int tries = 0;
                Random r = new Random();
                int randomNumber = r.Next(1, 101);
                
                

                int numberOfGuesses = 1;
                string response = "";

                while (response != "Match!")
                {
                    Console.WriteLine("Enter your lousy guess");
                    int userGuess = int.Parse(Console.ReadLine());
                    response = CheckGuess(userGuess, randomNumber);
                    Console.WriteLine(response);

                    numberOfGuesses++;

                }
                Console.WriteLine($"it took you {numberOfGuesses} to guess {randomNumber}");
                Console.WriteLine("Try again? (y/n)");
                userAnswer = Console.ReadLine();


            }


        }


        public static string CheckGuess(int guess, int number)
        {
            if (guess == number)
            {
                return "Match!";
            }
            int diff = guess - number;
            diff = Math.Abs(diff);

            if (guess > number)
            {
                if (diff > 10)
                {
                    return "Way too high!";
                }
                else
                {
                    return "too high!";
                }
            }
            else
            {
                if (diff > 10)
                {
                    return "Way too low!";
                }
                else
                {
                    return "too low!";

                }
            }
        }
    }
}
