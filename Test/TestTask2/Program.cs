using System;
using System.Text;
using Entities;

namespace TestTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str1 = new StringBuilder("abs");
            MyString myStr = new MyString(str1);

            String str2 = "vasya";
            MyString myStr2 = new MyString(str2);

            myStr.Reverse();
            myStr2.Reverse();
            Console.WriteLine(myStr);
            Console.WriteLine(str1);
            
            Console.WriteLine(myStr2);
            Console.WriteLine(str2);
        }
    }
}
