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

        public TileBag()
        {
            bag = new List<char> { 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a' 
                                   ,'e','e','e','e','e','e','e','e','e','e','e','e'                                             
                                   ,'i','i','i','i','i','i','i','i','i'
                                   ,'o','o','o','o','o','o','o','o'
                                   ,'n','n','n','n','n','n','r','r','r','r','r','r'
                                   ,'t','t','t','t','t','t','l','l','l','l','s','s','s','s'
                                   ,'u','u','u','u','d','d','d','d','g','g','g','b','b'
                                   ,'c','c','m','m','p','p','f','f','h','h','v','v','w','w','y','y'
                                   ,'k','j','x','q','z'                                             };

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
