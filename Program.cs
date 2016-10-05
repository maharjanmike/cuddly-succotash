using System;
using System.Collections.Generic;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = "egg";
            var second = "add";
            Console.WriteLine("Isomorphic = {0}", CheckIsomorphic(first, second));
            Console.ReadKey();
        }

        /// <summary>
        /// Check if the word is isomorhic,
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static bool CheckIsomorphic(string first, string second)
        {
            if ( first.Length != second.Length )
            {
                return false;
            }            
          
            var dict = new Dictionary<char, char>();
            var c1 = first.ToCharArray();
            var c2 = second.ToCharArray();

            for (int i = 0; i < first.Length; i++)
            {
                var firstWord = c1[i];
                var secondWord = c2[i];
                if (dict.ContainsKey(firstWord))
                {
                    if (dict[firstWord] != secondWord)
                    {
                        return false;
                    }
                }
                else
                {
                    if (dict.ContainsValue(secondWord))
                    {
                        return false;
                    }
                    dict.Add(firstWord, secondWord);
                }
            }
            return true;
        }
    }
}
