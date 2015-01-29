using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsWithEnemies
{
    class Game
    {
        public Game()
        {

        }


        public void Begin()
        {
            int winner = -1;
            AI ai = new AI();
            Human user = new Human();

            while (winner == -1)
            {
                Console.WriteLine("Welcome to Words with Enemies!");

                bool valid = false;

                do
                {
                    Console.WriteLine("Select an AI difficulty:");
                    Console.WriteLine("1) Easy");
                    Console.WriteLine("2) Hard");
                    Console.Write("--> ");
                    string userInput = Console.ReadLine();
                    if (userInput == "1" || userInput.ToLower() == "easy")
                    {
                        ai.difficulty = "easy";
                        Console.WriteLine("You have selected Easy! - Let's begin!");
                        valid = true;
                    }
                    else if (userInput == "2" || userInput.ToLower() == "hard")
                    {
                        ai.difficulty = "hard";
                        Console.WriteLine("You have selected Hard! - Let's begin!");
                        valid = true;
                    }

                }
                while (!valid);

                Console.WriteLine();

                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("Turn {0} -- Points You: {1}  Computer: {2}", i, user.score, ai.score);
                    Console.WriteLine("---------------------------------------------------------");
                    string userWord = user.SelectWord();
                    Console.WriteLine("Valid Word! Open Fire!!!!");
                    Console.ReadKey();
                }
            }
        }
    }
}
