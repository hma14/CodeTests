using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class TwoSum
    {
        public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
        {

#if true
            var result = from n1 in list
                         from n2 in list
                         where n1 + n2 == sum
                         select new Tuple<int, int>(list.IndexOf(n1), list.IndexOf(n2));
            return result.FirstOrDefault();
#else
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < list.Count(); i++)
            {
                dic[list[i]] = i;
            }

            for (int i = 0; i < list.Count(); i++)
            {
                int key = sum - list[i];
                if (dic.ContainsKey(key))
                {
                    return new Tuple<int, int>(i, dic[key]);
                }
            }
            return null;
#endif
        }

        public static void Main(string[] args)
        {
            Tuple<int, int> indices = FindTwoSum(new List<int>() { 1, 3, 5, 7, 9 }, 12);
            if (indices != null)
            {
                Console.WriteLine(indices.Item1 + " " + indices.Item2);
            }
            else
            {
                Console.WriteLine("Not found!");
            }
        }
    }
}
