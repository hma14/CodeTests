using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endianness
{
    class Endianness
    {
        public static int endianness()
        {
            unsafe
            {
                int v = 1;
                char* p = (char*)&v;
                return (*p);
            }
        }

        static void Main(string[] args)
        {
            if (endianness() > 0)
            {
                Console.WriteLine("This machine is Little Endian");
            }
            else
            {
                Console.WriteLine("This machine is Big Endian");
            }
        }
    }
}
