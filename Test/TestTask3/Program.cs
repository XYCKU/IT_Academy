using System;
using Entities;

namespace TestTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime.GetFromWorldCreation());
            Console.WriteLine(dateTime);
        }
    }
}
