using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConvertHexToIP
{
    class ConvertHexToIP
    {
        public static long ToInt(string addr)
        {
            return (long)(UInt32)IPAddress.NetworkToHostOrder((int)IPAddress.Parse(addr).Address);
        }
        public static string ToAddr(long address)
        {
            return IPAddress.Parse(address.ToString()).ToString();
        }

        public static UInt32 BitConverterToInt(string address)
        {
            return BitConverter.ToUInt32(IPAddress.Parse(address).GetAddressBytes(), 0);
        }

        public static string BitConverterToString(UInt32 intAddress)
        {
            return new IPAddress(BitConverter.GetBytes(intAddress)).ToString();
        }

        public static string ConHexToIP(UInt32 value)
        {
            const string s = "0123456789";
            char[] buff = new char[128];
            int i = 127;
            int count = 0;
            buff[i] = '\0';

            UInt32 subv = value & 0xFF;
            for (int j = 0; j < 4; ++j)
            {
                do
                {
                    count++;
                    buff[--i] = s[(int) subv % 10]; 
                } while ((subv /= 10) != 0);
                buff[--i] = '.';
                count++;
                value >>= 8;
                subv = value & 0xFF;
            }

            return new string(buff).Substring(buff.Length - count, count).TrimStart('.');
        }

        static void Main(string[] args)
        {
            UInt32 intAddress = 3091705030;
            long myIntAddress = 0;
            Console.WriteLine("{0} -> {1} ", intAddress, ConHexToIP(intAddress));

            string ipAddress = "184.71.172.198";
            intAddress = BitConverterToInt(ipAddress);
            Console.WriteLine("BitConverterToInt: {0} -> {1} ", ipAddress, intAddress);

            // Note: IP address will be reversed form 184.71.172.198 to 198.172.71.184
            ipAddress = BitConverterToString(intAddress);
            Console.WriteLine("BitConverterToString: {0} -> {1} ", intAddress, ipAddress);

            myIntAddress = ToInt(ipAddress);
            Console.WriteLine("ToInt: {0} -> {1} ", ipAddress, myIntAddress);
            ipAddress = ToAddr(myIntAddress);
            Console.WriteLine("ToAddr: {0} -> {1} ", myIntAddress, ipAddress);
        }
    }
}
