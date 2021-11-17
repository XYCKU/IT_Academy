using System;
using System.Collections.Generic;
using Models;

namespace Hw10Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList items = new MyList();
            items.Add(new MyItem("String1", 5));
            items.Add(new MyItem("String2", 15));
            items.Add(new MyItem("Pablo", 64));

            Console.WriteLine(items);

            items.RemoveAt(0);
            items.Clear();
            Console.WriteLine(items);

            items.Add(new MyItem("String1", 5));
            items.Add(new MyItem("String2", 15));
            items.Add(new MyItem("Pablo", 64));
            Console.WriteLine(items);


        }
    }
}
