using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindN
{
    class FindN
    {
        public static int findN(int [] arr, int n)
        {
            var results = arr.Where(x => x == n || x < n).ToList();
            return results.FirstOrDefault();
        }
        static void Main(string[] args)
        {
            // Not working
            int [] a = { 13, 5, 8, 2, 6, 9, 10, 43, 100 };
            int N = 43;
            Console.WriteLine(findN(a, N));
        }
    }
}
