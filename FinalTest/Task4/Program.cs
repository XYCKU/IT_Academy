using System;
using Models;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EventClass.OnAnnualCall += () => { Console.WriteLine("Event invoked"); };
            EventClass ec1 = new EventClass();
            EventClass ec2 = new EventClass();
            for (int i = 0; i < 30; ++i)
            {
                ec1.Method();
                ec2.Method();
            }
        }
    }
}
