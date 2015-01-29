using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordsWithEnemies
{
    class Dictionary
    {
        private static HashSet<String> words;
 

        public static void Initialize()
        {
            try
            {
                using (StreamReader read = new StreamReader("twl06.txt"))
                {
                   String[] temp = read.ReadToEnd().Split(' ');
                   words = new HashSet<string>(temp);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
    }
}
