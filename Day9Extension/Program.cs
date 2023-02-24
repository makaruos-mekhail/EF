// See https://aka.ms/new-console-template for more information

using Day9Extension;
using System;
using System.Collections.Generic;

namespace Day9
{
    class Program
    {
        //static List<int> list = new List<int>() { 1, 2, 3 };

        //static IEnumerable<int> Sequence()
        //{

        //    foreach (var item in list)
        //    {
        //        yield return item;
        //    }
        //    //return list;

        //    //Console.WriteLine("1");

        //    //yield return 1;
        //    //Console.WriteLine("2");
        //    //yield return 2;
        //    //Console.WriteLine("3");
        //    //yield return 3;
        //}
        //static IEnumerable<int> Test()
        //{
        //    //return new List<int> { list[0], list[1], list[2] };
        //    foreach (var item in list)
        //    {
        //        yield return item;
        //    }
        //}
        static void Main(string[] args)
        {
            #region Implicitly Local Typed Variable 
            //var x = 4;
            //var lus = new List<Employee>();

            //var employees = new List<Employee>();
            #endregion

            #region Anynomous Object 
            //Employee employee = new Employee();

            //var emp = new { fname = "asd", lname = "add", Id = 1 };
            //Console.WriteLine(emp.fname);
            //var emp2 = new { fname = "asd2", lname = "add2", Id = 2 };
            #endregion

            #region Extension Method
            //List<int> mylist = new List<int>();
            //mylist.Add(1);
            //mylist.Add(3);
            //mylist.Add(4);
            //mylist.Add(16);
            //mylist.Add(-1);
            //mylist.Add(12);

            //DisplayList displayList = new DisplayList();
            //displayList.Display(mylist, i => i %2== 0);
            //mylist.Display(i => i % 2 == 0);
            //List<string> strlist = new List<string>();
            //strlist.Display(u => u.Contains("s"));

            //string msg = "asdas-fds+dasd/gfdg";
            //string ers = msg.RemoveSpace();
            //Print(GetLength(RemoveSpace(msg)));
            //string msg = "asdas-fds+dasd/gfdg";
            //msg.RemoveSpace().Print();



            #endregion

            #region Deffeared & Eager Execution 
            //IEnumerable<int> list = Sequence();
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //IEnumerable<int> Currlist = Test();
            //foreach (var item in Currlist)
            //{
            //    Console.WriteLine(item);
            //}
            //list[0] = 20; 
            //foreach (var item in Currlist)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
          
            //task1

            int reverse = 6598;
            reverse.ReverseNum().Printnum();
            reverse.NoofDigit().Printnum();

            //task2

            string str = "Hall-oMaka+ruo*sMe/khail";
            List<char> Special_chars = new List<char>() { '-', '+', '/', '*' };
            str = str.RemoveSpecial(Special_chars);
            str.Print();

            //task3
            int[] num = { 20, 5, 41, 85, 10, 1, 2 };
            num.GetMaxo().Printnum();


        }

    }
}
