using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsWithEnemies
{
    class Player
    {
        public int score { get; set; }
        public List<char> hand { get; set; }
        private TileBag bag = new TileBag();

        public Player()
        {
            hand = new List<char>();
            score = 0;
            Fillhand();
        }

        public void Fillhand()
        {
            for (int i = hand.Count; i < 9; i++)
            {
                hand.Add(bag.Draw());
            }
        }

        private void ClearHand()
        {
            hand.Clear();
        }

        public void Reset()
        {
            bag.FillBag();
            bag.ShuffleBag();
            ClearHand();
        }

        public void RemoveFromHand(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                hand.Remove(word[i]);
            }
        }

    }
}
