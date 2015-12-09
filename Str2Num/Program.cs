using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Str2Num
{
    class Program
    {
        static void Main(string[] args)
        {
            const string input = "567234";
            try
            {
                Console.WriteLine(string.Format("Input string: '{0}' and converted to number: {1}", 
                                    input, Str2Num(input)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("---------------");
            Console.WriteLine();
            Console.WriteLine("Converted {0} back to string: '{1}'", input, Num2Str(Str2Num(input)));
            Console.WriteLine("-198 -> {0} ", Num2Str(-198));
        }

        static long Str2Num(string numStr)
        {
            long ret = 0;
            char[] arr = numStr.ToArray();
            foreach (var ch in arr)
            {
                if (ch < '0' || ch > '9')
                {
                    throw new Exception("Input string is not a number string! Please use number string only. I.e. '2345'");
                }
                ret = ret * 10 + ch - '0';
            }
            return ret;
            
        }

        static string Num2Str(long num)
        {
            const string numMap = "0123456789";
            char[] arr = new char[32];
            int i = arr.Length;
            bool isMinus = false;
            if (num < 0)
            {
                num = -num;
                isMinus = true;
            }
            do
            {
                arr[--i] = numMap[(int) num % 10];
            } while ((num /= 10) != 0);
            if (isMinus)
            {
                arr[--i] = '-';
            }
            return new String(arr).Substring(i);
        }
    }
}
