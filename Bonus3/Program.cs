using System;

namespace Bonus3
{
    class Program
    {
        static void Main(string[] args)
        {


            Random r = new Random();
            int number = r.Next(1, 101);
            int tries = 0;

            

            Console.WriteLine("Welcome to the Guess a Number Game!");
            Console.WriteLine("++++++++++++++++++++++++++++++");

            Console.WriteLine("I am thinking of a number between 1 and 100.");
            Console.WriteLine("Try to guess it, n00b.");


            string response = "";
            while (response != "Match!")
            {
                int num = GetUserGuess();

                response = Guess(num, number);
                Console.WriteLine(response);
                Console.WriteLine();
            }

            Console.WriteLine($"it took you {tries} to guess {number}");

            Console.WriteLine();
            Console.WriteLine("This version guesses starting at one and ticks up to 100");
            int guess = 1;
            response = "";
            while (response != "Match!")
            {
                response = GetUserGuess(, number);
                if (response != "Match!")
                {
                    guess++;


                }

            }
        }

        private static int GetUserGuess()
        {
            throw new NotImplementedException();
        }

        public static int GetUserGuess(int current, int number)
        {
            while (true)
            {
                Console.WriteLine("Please guess a number between 1 and 100 and I will tell how close you are");
                try
                {
                    int num = int.Parse(Console.ReadLine());
                    if (num < 1)
                    {
                        throw new Exception("That number is too small, please input a number between 1 and 100");
                    }
                    else if (num > 100)
                    {
                        throw new Exception("That number is too large, please inptu a number between 1 and 100");
                    }
                    return num;

                }
                catch (FormatException)
                {
                    Console.WriteLine("That was not a valid number please try again");
                    continue;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }
        }

        public static string Guess(int guess, int number)
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
