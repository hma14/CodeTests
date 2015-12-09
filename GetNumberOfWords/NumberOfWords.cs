using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetNumberOfWords
{
    class NumberOfWords
    {
        public static bool CompareDateTime(DateTime dt)
        {
            if (dt == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static int GetNoofWordsInStrings(string words)
        {
            string[] arr = words.Split(' ');
            return arr.Length;
        }
        static void Main(string[] args)
        {
            const string words = "coding is fun";
            Console.WriteLine("Number of words in '{0}' : {1}", words, GetNoofWordsInStrings(words));

            DateTime dt = DateTime.MinValue;
            Console.WriteLine("Is it true? {0}", CompareDateTime(dt));
        }
    }
}
