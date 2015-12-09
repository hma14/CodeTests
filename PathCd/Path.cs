using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PathCd
{
    class Path
    {
        public string CurrentPath { get; private set; }

        public Path(string path)
        {
            this.CurrentPath = path;
        }

        public Path Cd(string newPath)
        {
            string[] arr = CurrentPath.TrimStart('/').Split('/');
            string[] newPathArr = Regex.Split(newPath, "../");
            string[] newArr;
            string[] finalArr;
            int pos = arr.Length - newPathArr.Length + 1;
            if (pos <= 0)
            {
                return new Path("/");
            }
            if (pos >= arr.Length)
            {
                newArr = new string[pos - arr.Length + 1];
                finalArr = arr.Concat(newArr).ToArray();
                finalArr[pos] = newPathArr[newPathArr.Length - 1];
                int index = Array.FindIndex(finalArr, x => x == finalArr[pos]);
                string[] sub = new List<string>(finalArr).GetRange(0, index + 1).ToArray();
                Path path = new Path(String.Join("/", sub));
                return path;
            }
            else
            {
                arr[pos] = newPathArr[newPathArr.Length - 1];
                int index = Array.FindIndex(arr, x => x == arr[pos]);
                string[] sub = new List<string>(arr).GetRange(0, index + 1).ToArray();
                Path path = new Path(String.Join("/", sub));
                return path;
            }
            
        }

        public static void Main(string[] args)
        {
            Path path = new Path("/a/b/c/d");
            Console.WriteLine(path.Cd("../../../../x").CurrentPath);
        }
    }
}
