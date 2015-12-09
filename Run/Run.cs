using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/***

    Write a function that finds the zero-based index of the longest run in 
    a string. A run is a consecutive sequence of the same character. If there 
    is more than one run with the same length, return the index of the first one.

    For example, IndexOfLongestRun("abbcccddddcccbba") should return 6 as the 
    longest run is dddd and it first appears on index 6.
    ***/

public class Run
{
    public static int IndexOfLongestRun(string str)
    {
        string retval = string.Empty;
        string firstOccurence = string.Empty;
        string maxOccurence = string.Empty;
        string val1 = string.Empty;
        string val2 = string.Empty;
        int occurenceCounter = 1;
        int maxOccur = 0;

        for (int i = 0; i < str.Length; i++)
        {
            val1 = str[i].ToString();
            if (i < str.Length - 1)
            {
                val2 = str[i + 1].ToString();
            }
            else
            {
                val2 = str[i].ToString();
            }

            if (val1 == val2)
            {
                firstOccurence = val1;
                occurenceCounter++;

                if (occurenceCounter > maxOccur)
                {
                    maxOccur = occurenceCounter;
                    maxOccurence = firstOccurence;
                }
                continue;
            }
            else
            {
                occurenceCounter = 1;
            }
        }
        return str.IndexOf(maxOccurence, 0);

        //var distinctChars = str.Distinct();
        //foreach(char c in distinctChars)
        //{
        //    if (str.Count(p => p == c) > 1)
        //    {

        //    }
        //}
        //var grouped = str
        //    .GroupBy(s => s)
        //    .Select(g => new { ch = g.Key, count = g.Count()})            
        //    .OrderByDescending(x => x.count).ToList();

        //return  str.IndexOf(grouped.FirstOrDefault().ch);

        //var list = str.ToList();
        //var grouped = str
        //    .GroupBy(s => s)
            
        //    .Where( (c, i) => i > 0 && c == str[i-1])
        //    .Select(g => new { word = g.Key, count = g.Count() })
        //    .Cast<char?>()
        //    .OrderByDescending(x => x.count);

        //return grouped.FirstOrDefault().count;
#if false
        Dictionary<char, int> dic = new Dictionary<char, int>();
        for (int i = 0; i < str.Length; i++)
        {
            if (!dic.ContainsKey(str[i]))
            {
                dic.Add(str[i], 1);
            }
            else
            {
                dic[str[i]]++;
            }
        }
        //var sortedDic = from entry in dic orderby entry.Value descending select entry;
        dic = dic.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        var key = dic.FirstOrDefault().Key;

        return str.ToList().IndexOf(key);
#endif
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(IndexOfLongestRun("abbcccddddcccbbaeeeeeeffgggggeeeddd"));
    }
}
