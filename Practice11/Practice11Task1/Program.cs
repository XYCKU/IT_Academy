using System;
using System.Collections.Generic;
using Models;

namespace Practice11Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car(1, Colors.Red);
            var car2 = new Car(1, Colors.Red);

            Console.WriteLine($"==: {car1 == car2}");
            Console.WriteLine($"Equals: {car1.Equals(car2)}");
            Console.WriteLine($"ReferenceEquals: {ReferenceEquals(car1, car2)}");

            List<Car> cars = new List<Car>();
            cars.Add(car1);
            cars.Add(car2);
            cars.Add(new Car(5, Colors.Green));
            cars.Add(new Car(3, Colors.Black));

            cars.Sort();
            foreach(var item in cars)
            {
                Console.WriteLine(item);
            }
        }
    }
}
