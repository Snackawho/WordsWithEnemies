using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsWithEnemies
{
    class Human : Player
    {
        public Human()
        {

        }

        public string SelectWord()
        {
            string userInput = "";
            do 
            {
                Console.Write("Your letters: ");

                for (int i = 0; i < hand.Count; i++)
                {
                    Console.Write(hand[i] + " ");
                }
                Console.WriteLine();
                Console.Write("Your Word-> ");
                userInput = Console.ReadLine();

            } while (!(CheckLetters(new List<char>(userInput)) && Dictionary.CheckWord(userInput))); //Checks to see if the letters exist in hand and if the Word exists in the Dictionary

            RemoveFromHand(userInput);
            return userInput;
        }

        private Boolean CheckLetters(List<char> userInput)
        {
            string s = Utility.ConvCharListToString(userInput);
            List<char> tempList = new List<char>(hand);
            
            for (int i = 0; i < userInput.Count; i++)
            {
                if (tempList.Contains(userInput[i])) 
                {
                    tempList.Remove(userInput[i]);
                    userInput.RemoveAt(i);
                    i = -1;
                }
            }

            if (userInput.Count == 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("I am sorry but you cannot spell " + s + " with your letters. Try again");
                return false;
            }
                
        }
    }
}
