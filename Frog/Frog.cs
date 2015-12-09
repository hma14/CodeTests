using System;
using System.Collections.Generic;

namespace Frog
{
    public class Frog
    {
        public static void Main(String[] args)
        {
           // Console.WriteLine(NumberOfWays(7));
           Console.WriteLine(NumberOfWays(7));
        }

        public static int NumberOfWays(int n)
        {
            return NoOfPermutaions(NoOfCombinations(n));
        }

        private static List<Tuple<int, int>> NoOfCombinations(int distance)
        {
            List<Tuple<int, int>> lst = new List<Tuple<int, int>>();
            for (int i = 0; i <= distance; i++)
                for (int j = 0; j <= distance; j++)
                {
                    if ((i * 1 + j * 2) == distance)
                        lst.Add(new Tuple<int, int>(i, j));
                }
            return lst;
        }

        private static int NoOfPermutaions(List<Tuple<int, int>> lst)
        {
            int Sum = 0;
            foreach (Tuple<int, int> itm in lst)
            {
                // c(n,r) = n! / ( r! * (n-r)! )
                Sum += Convert.ToInt32(Factorial(itm.Item1 + itm.Item2) / (Factorial(itm.Item1) * Factorial(itm.Item2))); //Formula: C(n,r)=n!/r!;
            }


            return Sum;
        }

        private static double Factorial(double num)
        {
            if (num <= 1)
                return 1;
            return num * Factorial(num - 1);
        }
    }
}
