using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsWithEnemies
{
    class AI : Player
    {
        public string difficulty {get; set;}

        public AI() 
        {

        }

        public string SelectWord()
        {
            //Console.WriteLine("AI's hand: " + Utility.ConvCharListToString(hand));
            List<string> possibleWords = Dictionary.ReturnWordsForList(hand);

            if (difficulty == "easy")
            {
                String word = SelectEasyWord(possibleWords);
                RemoveFromHand(word);
                return word;
            }
            else if (difficulty == "medium")
            {
                String word = SelectMediumWord(possibleWords);
                RemoveFromHand(word);
                return word;
            }
            else if (difficulty == "hard")
            {
                String word = SelectHardWord(possibleWords);
                RemoveFromHand(word);
                return word;
            }
            else
            {
                return null;
            }

        }

        private string SelectEasyWord(List<string> words)
        {
            return words[0];
        }

        private string SelectMediumWord(List<string> words)
        {
            Random rand = new Random();
            return words[rand.Next(0, words.Count)];
        }

        private string SelectHardWord(List<string> words)
        {
            string word = words[0];

            foreach (string w in words)
            {
                if (w.Length > word.Length)
                {
                    word = w;
                }
            }

            return word;
        }

    }
}
