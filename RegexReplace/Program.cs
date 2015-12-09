﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input strings.
            const string s1 = "marcus aurelius";
            const string s2 = "the golden bowl";
            const string s3 = "Thomas jefferson";

            // Write output strings.
            Console.WriteLine(TextTools.UpperFirst(s1));
            Console.WriteLine(TextTools.UpperFirst(s2));
            Console.WriteLine(TextTools.UpperFirst(s3));
        }
    }

    public static class TextTools
    {
        /// <summary>
        /// Uppercase first letters of all words in the string.
        /// </summary>
        public static string UpperFirst(string s)
        {
            return Regex.Replace(s, @"\b[a-z]\w+", delegate (Match match)
            {
                string v = match.ToString();
                return char.ToUpper(v[0]) + v.Substring(1);
            });
        }
    }
}
