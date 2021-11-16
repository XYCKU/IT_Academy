using System;
using Models;

namespace Hw9Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myCol = new MyCollection<Transport>();
            myCol.Add(new Boat(55, "boaty"));
            myCol.Add(new Car(66, "speedy"));
            myCol.Add(new Boat(2, "ship"));
            myCol.Add(new Car(190, "speeder"));

            Console.WriteLine(myCol.Count);
            for (int i = 0; i < myCol.Count; i++)
            {
                Console.WriteLine(myCol[i]);
            }
        }
    }
}
