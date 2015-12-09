using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeTests
{
    class Palindrome
    {
        public static bool IsPalindrome(string str)
        {
            string tmpStr = str.ToLower().Trim();
            tmpStr = Regex.Replace(tmpStr, @"[^a-zA-Z]+", "");  //Replace all the special characters
            return tmpStr.SequenceEqual(tmpStr.Reverse());
        }
        static void Main(string[] args)
        {
            const string input = "Noel sees, Leon."; //"nurses run"; //"madam"; 
            Console.WriteLine(IsPalindrome(input));
        }
    }
}
