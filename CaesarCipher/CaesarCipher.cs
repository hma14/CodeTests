using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class CaesarCipher
    {
        static string Caesar(string str, int k)
        {
            var ret = new string(str.ToCharArray().Select(c => Convert.ToChar(c + k)).ToArray());
            return ret;
        }
        static void Main(string[] args)
        {
            string input = "Variable value will now have 97 which corresponds to the value of that ascii character";
            Console.WriteLine(Caesar(input, 3));
        }
    }
}
