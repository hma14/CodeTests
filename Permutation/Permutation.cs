using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation
{
    public class Permutation
    {
        static List<string> list = new List<string>();
        public static ICollection<string> permuteString(String beginningString, String endingString)
        {
            if (endingString.Length <= 1)
            {
                list.Add(beginningString + endingString);
            }
            else
            {
                for (int i = 0; i < endingString.Length; i++)
                {
                    String newString = endingString.Substring(0, i) + endingString.Substring(i + 1);
                    permuteString(beginningString + endingString.ElementAt(i), newString);
                }
            }

            return list.Distinct().ToList();
        }


        static void Main(string[] args)
        {
            ICollection<string> anagrams =  Permutation.permuteString(String.Empty, "abba");
            foreach (string a in anagrams)
                Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
