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

            AI ai = new AI();
            Human user = new Human();

            Console.WriteLine("Welcome to Words with Enemies!");

            bool valid = false;

            do
            {
                Console.WriteLine("Select an AI difficulty:");
                Console.WriteLine("1) Easy");
                Console.WriteLine("2) Medium");
                Console.WriteLine("3) Hard");
                Console.Write("--> ");
                string userInput = Console.ReadLine();
                if (userInput == "1" || userInput.ToLower() == "easy")
                {
                    ai.difficulty = "easy";
                    Console.WriteLine("You have selected Easy! - Let's begin!");
                    valid = true;
                }
                else if (userInput == "2" || userInput.ToLower() == "medium")
                {
                    ai.difficulty = "medium";
                    Console.WriteLine("You have selected Medium! - Let's begin!");
                    valid = true;
                }
                else if (userInput == "3" || userInput.ToLower() == "hard")
                {
                    ai.difficulty = "hard";
                    Console.WriteLine("You have selected Hard! - Let's begin!");
                    valid = true;
                }
                else
                {
                    Console.WriteLine("That's not a proper command. Please try again");
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
                string aiWord = ai.SelectWord();
                Console.WriteLine("AI selects \"{0}\"", aiWord);
                Console.WriteLine();
                Score(user, userWord, ai, aiWord);
                user.Fillhand();
                ai.Fillhand();
                Console.WriteLine();
            }
            Console.WriteLine("Final Score. You: {0} Computer: {1}", user.score, ai.score);
            DetermineWinner(user, ai);

        }

        private void DetermineWinner(Human user, AI ai)
        {
            Console.WriteLine();
            if (user.score > ai.score)
            {
                Console.WriteLine("You WIN!");
            }
            else if (user.score < ai.score)
            {
                Console.WriteLine("You LOSE!");
            }
            else
            {
                Console.WriteLine("This game is a tie");
            }

            Console.WriteLine();
            Console.WriteLine("Would you like to play again. Type yes to retry");
            string again = Console.ReadLine();

            if (again == "yes")
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine();
                Begin();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void Score(Human userPlayer, string userWord, AI ai, string aiWord)
        {
            List<char> userLetters = new List<char>(userWord);
            List<char> aiLetters = new List<char>(aiWord);

            for (int i = 0; i < userLetters.Count(); i++)
            {
                if (aiLetters.Contains(userLetters[i]))
                {
                    aiLetters.Remove(userLetters[i]);
                    userLetters.RemoveAt(i);
                    i = -1;
                }
            }

            userPlayer.score += userLetters.Count();
            ai.score += aiLetters.Count();

            Console.Write("{0} vs {1} :", userWord, aiWord);

            if (userLetters.Count() > aiLetters.Count())
            {
                Console.WriteLine("You win");
            }
            else if (userLetters.Count() < aiLetters.Count())
            {
                Console.WriteLine("The AI wins");
            }
            else
            {
                Console.WriteLine("No one wins");
            }

            Console.WriteLine("You scored {0} points", userLetters.Count());
            Console.WriteLine("The AI scored {0} points", aiLetters.Count());
        }
    }
}
