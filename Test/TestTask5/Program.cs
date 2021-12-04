using System;
using Entities.Task5;

namespace TestTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Entity ent = new Entity("Ancient entity", 44);
            Hero ply = new Hero("Williamson", 44, 25);
            Monster crt = new Monster("Bob", 2, 5);
            ent.Display();
            ply.Display();
            crt.Display();

            Console.WriteLine(ent.Action());
            Console.WriteLine(ply.Action());
            Console.WriteLine(crt.Action());
        }
    }
}
