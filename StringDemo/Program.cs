using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "hello world!";
            string str2 = " good evening everyone ";
            string str3 = str1;

            Console.WriteLine($"length of string1: {str1.Length}");
            Console.WriteLine($"length of string2: {str2.Length}");
            string str4=String.Concat(str1," ",str2);
            Console.WriteLine(str4);

            string str5 = str4.Substring(6);
            Console.WriteLine(str5);

            char[] chars = str4.ToCharArray(7,11);
            foreach (var item in chars)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(str1.ToUpper());
            Console.WriteLine(str1.ToLower());

            Console.WriteLine(str2.TrimEnd());

            Console.WriteLine(str1.GetHashCode());
            Console.WriteLine(str3.GetHashCode());

          bool result = str1.Equals(str3);
            bool result1 = str1.Equals(str2);
            Console.WriteLine(result);
            Console.WriteLine(result1);
        }
    }
}
