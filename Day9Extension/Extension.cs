using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Day9Extension
{
    static class Extension
    {
        #region Demo
        //public static void Display<T>(this IEnumerable<T> li, Predicate<T> predicate)
        //{
        //    foreach (var item in li)
        //    {
        //        if (predicate(item))
        //            Console.WriteLine(item);
        //    }
        //}
        //public static string RemoveSpace(this string str)
        //{
        //    string temp = "";
        //    foreach (var item in str)
        //    {
        //        if (item != '/')
        //            temp += item;
        //    }
        //    return temp;
        //}
        //public static int GetLength(this string str)
        //{
        //    return str.Length;
        //}
        #endregion

        //task1
        public static int ReverseNum(this int num)
        {
            string numstr = num.ToString();
            var reverse = numstr.Reverse();
            StringBuilder result = new();
            foreach(var item in reverse)
            {
                result.Append(item);
            }
            return int.Parse(result.ToString());
        }
        public static int NoofDigit(this int num)
        {
            return num.ToString().Length;
        }
        public static void Printnum(this int num)
        {
            Console.WriteLine($"\n{num}");
        }

        //task2
        public static string RemoveSpecial(this string str, List<char> Special_chars)
        {
            //foreach (char c in Special_chars)
            //{
            //    str = str.Replace(c.ToString(),String.Empty);
            //}
            //return str;
            return String.Concat(str.Split(Special_chars.ToArray()));

        }
        public static void Print(this string num)
        {
            Console.WriteLine($"\n{num}");
        }

        //task3
        public static int GetMaxo(this IEnumerable<int> intmax)
        {
            int NumMax = intmax.First();

            foreach (int x in intmax)
            {
                if(x > NumMax)
                {
                    NumMax = x;
                }
            }
            return NumMax;
        }


    }

}
