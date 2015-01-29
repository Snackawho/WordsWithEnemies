using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsWithEnemies
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary.Initialize();
            List<char> temp = new List<char> {'o','m','a','r','n','o'};
       
            List<String> temp2 = Dictionary.ReturnWordsForList(temp);
            foreach (String word in temp2)
            {
                Console.Write(word + " ");
            }
            Console.ReadKey();
        }
    }
}
