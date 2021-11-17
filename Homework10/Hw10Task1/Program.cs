using System;
using System.Collections.Generic;
using Models;

namespace Hw10Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();
            MyList items = new MyList();
            items.Add(new MyItem("String1", 5));
            items.Add(new MyItem("String2", 15));
            items.Add(new MyItem());

            foreach(var item in items)
            {
                Console.WriteLine(item);
            }

            items.RemoveAt(0);
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(items.Capacity);


            ints.Add(1);
            ints.Add(1);
            ints.Add(1);
            ints.Add(1);
            ints.Add(1);
            Console.WriteLine(ints.Capacity);
        }
    }
}
