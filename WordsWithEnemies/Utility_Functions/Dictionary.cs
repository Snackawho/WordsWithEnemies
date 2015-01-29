using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace WordsWithEnemies
{
    class Dictionary
    {
        private static HashSet<String> Words;
        private static List<String> words;


        public static void Initialize()
        {
            try
            {
                using (StreamReader read = new StreamReader("twl06.txt"))
                {
                    Regex regex = new Regex(@"\b\r\n\b");
                    String[] temp = regex.Split(read.ReadToEnd());
                    Words = new HashSet<string>(temp);

                    words = new List<string>(temp);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        public static Boolean CheckWord()
        {
            return true;
        }

        public static List<String> ReturnWordsForList(List<char> letters)
        {
            List<String> returnWords = new List<String>();

            foreach (string word in words)
            {
                List<char> temp = new List<char>(letters);

                
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (temp.Contains(word[i]))
                        {
                            for (int j = 0; j < temp.Count; j++)
                            {
                                if (temp[j] == word[i])
                                {
                                    temp.RemoveAt(j);
                                    break;
                                }
                            }
                        }
                        else
                        {
                            break;
                        }

                        if (i == word.Length - 1)
                        {
                            returnWords.Add(word);
                        }
                    }
            }
          return returnWords;
        }
    }
}
