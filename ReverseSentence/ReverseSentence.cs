using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseSentence
{
    class ReverseSentence
    {
        static void Main(string[] args)
        {
            const string inString = @"Token A^*!%~Token B^*!%~Token C^*!%~Token D^*!%~Token E";
            const string inString2 = "In the previous tutorials you worked";

            Console.WriteLine(" -------- ");
            Console.WriteLine(inString);
            Console.WriteLine();
            Console.WriteLine(ReverseTokens(inString));
            Console.WriteLine();

            Console.WriteLine(" -------- ");
            Console.WriteLine(inString2);
            Console.WriteLine();
            Console.WriteLine(ReverseStrings(inString2));

        }

        static string ReverseTokens(string str)
        {
            const string delimiter = @"^*!%~";
            const char newDelimiter = '|';
            return String.Join(" ", str.Replace(delimiter, newDelimiter.ToString()).Split(newDelimiter).Reverse().ToArray());
        }

        static string ReverseStrings(string str)
        {
            return String.Join(" ", str.Split(' ').Select(s => new String(s.Reverse().ToArray())));
        }
    }
}
