using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    /**
        An anagram is a word formed from another by rearranging its letters, 
        using all the original letters exactly once; for example, orchestra 
        can be rearranged into carthorse.
    **/
    
    class Program
    {
        public static bool AreStringsAnagrams(string str1, string str2)
        {
            if (String.IsNullOrEmpty(str1) || String.IsNullOrEmpty(str2))
                return false;
            else if (str1.Length != str2.Length)
                return false;
            else if (str1.Equals(str2))
                return true;


#if true
            return str1.OrderBy(s => s).SequenceEqual(str2.OrderBy(s => s));
#else
            Dictionary<char, int> dic1 = new Dictionary<char, int>();
            Dictionary<char, int> dic2 = new Dictionary<char, int>();
            for (int i = 0; i < str1.Length; i++)
            {
                if (!dic1.ContainsKey(str1[i]))
                {
                    dic1.Add(str1[i], 1);
                }
                else
                {
                    dic1[str1[i]]++;
                }
                if (!dic2.ContainsKey(str2[i]))
                {
                    dic2.Add(str2[i], 1);
                }
                else
                {
                    dic2[str2[i]]++;
                }
            }

            for (int i = 0; i < str1.Length; i++)
            {
                if (dic1.ContainsKey(str2[i]) == false || dic2[str2[i]] != dic1[str2[i]])
                    return false;
            }
            return true;
#endif
        }

        public static void Main(string[] args)
        {
            //Console.WriteLine(AreStringsAnagrams("satin", "stain"));
            Console.WriteLine(AreStringsAnagrams("momdad", "dadmom"));
            Console.ReadLine();
        }
    }
}
