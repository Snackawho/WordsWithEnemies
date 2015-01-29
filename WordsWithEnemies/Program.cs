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
            Game game = new Game();
            game.Begin();


            Console.ReadKey();
        }
    }
}
