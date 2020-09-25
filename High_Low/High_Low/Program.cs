using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_Low
{
    class Program
    {
        static void Main(string[] args)
        {
            int games = 0;
            while (true)
            {
                games += 1;
                // Display welcome message
                Console.WriteLine("Welcome to the high low game!");
                Console.WriteLine("I am going to pick a number between 1 and 100, and you will guess the number.");
                Console.WriteLine("When you make a guess, I well tell you whether it's higher or lower than your guess.");
                Console.WriteLine();

                Game(Difficulty());

                Console.WriteLine();
                // Ask user if they would like to play again
                if (Play_Again() == false)
                {
                    string game_plural;
                    if (games == 1)
                    {
                        game_plural = "game";
                    }
                    else
                    {
                        game_plural = "games";
                    }
                    Console.WriteLine("You played " + games.ToString() + " " + game_plural + "!");
                    break;
                }
            }

            Console.WriteLine();
            // Wait for key press
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        static bool Play_Again()
        {
            while (true)
            {
                Console.WriteLine("Would you like to play again?(y/n)");
                Console.Write(">>> ");
                string yn = Console.ReadLine().ToLower();
                if (yn == "y")
                {
                    Console.WriteLine();
                    return true;
                }
                else if (yn == "n")
                {
                    return false;
                }
            }
        }
        static void Game(int difficulty)
        {
            int highest = 0;
            int lowest = 0;
            // Random number generator
            Random rng = new Random();
            if (difficulty == 1)
            {
                lowest = 1;
                highest = 100;
            }
            if (difficulty == 2)
            {
                lowest = 1;
                highest = 1000;
            }
            if (difficulty == 3)
            {
                lowest = -1000;
                highest = 1000;
            }
            int answer = rng.Next(lowest, highest);

            while (true)
            {
                // User enters a guess
                int guess;
                while (true)
                {
                    try
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Enter guess (between {lowest} and {highest}): ");
                        Console.Write(">>> ");
                        guess = Convert.ToInt32(Console.ReadLine());
                        if ((guess < highest) && (guess > lowest))
                        {
                        break;
                        }
                    }
                    catch { }
                }

                // Compare guess with answer
                if (guess < answer)
                {
                    Console.WriteLine("Higher");
                    lowest = guess;
                }
                else if (guess > answer)
                {
                    Console.WriteLine("Lower");
                    highest = guess;
                }
                else if (guess == answer)
                {
                    Console.WriteLine(answer.ToString() + " is the correct answer!");
                    break;
                }
            }
        }

        static int Difficulty()
        {
            Console.WriteLine();
            Console.WriteLine("1. Easy (1 ~ 100)");
            Console.WriteLine("2. Medium (1 ~ 1000)");
            Console.WriteLine("3. Hard (-1000 ~ 1000)");
            Console.WriteLine();
            while (true)
            {
                int selection;
                try
                {
                    Console.Write(">>> ");
                    selection = int.Parse(Console.ReadLine());
                    if ((selection >= 1) && (selection <= 3))
                    {
                        return selection;
                    }
                }
                catch { }
            }
        }
    }
}
