using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsWithEnemies
{
    class Utility
    {
        public static List<T> ShuffleList<T>(List<T> list)
        {
            int n = list.Count();
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                int r = i + (int)(rand.NextDouble() * (n - i));
                T temp = list[r];
                list[r] = list[i];
                list[i] = temp;
            }

            return list;
        } 
    }
}
