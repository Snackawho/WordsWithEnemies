using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WordsWithEnemies
{
    class TileBag
    {
        private List<Char> bag;
        private int[] letterCount = { 9, 2, 2, 4, 12, 2, 3, 2, 9, 1, 1, 4, 2, 6, 8, 2, 1, 6, 4, 6, 4, 2, 2, 1, 2, 1 };

        public TileBag()
        {
            bag = new List<char> ();
            FillBag();
            ShuffleBag();
        }

        public void FillBag() {
            bag.Clear();
            int count = 0;
            for (char letter = 'a'; letter < 'z'; letter++)
            {
                for (int i = 0; i < letterCount[count]; i++)
                {
                    bag.Add(letter);
                }
                count++;
            }
        }

        public void ShuffleBag()
        {
            bag = Utility.ShuffleList<char>(bag);
        }

        public char Draw()
        {
            char letter = bag[0];
            bag.RemoveAt(0);

            return letter;
        }

    }
}
