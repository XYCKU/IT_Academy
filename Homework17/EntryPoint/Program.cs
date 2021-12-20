using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Models;

namespace EntryPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int size = 100000;
            List<Car> cars = new List<Car>(size);
            for (int i = 0; i < cars.Capacity; i++)
            {
                cars.Add(new Car(i));
            }

            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            foreach(var car in cars)
            {
                car.Age = (343 * 34 * DateTime.Now.Millisecond * 77) / DateTime.Now.Minute;
            }
            stopWatch.Stop();
            Console.WriteLine($"Default ForEach result is \t{stopWatch.Elapsed}");

            stopWatch.Restart();
            for (int i = 0; i < cars.Count; i++)
            {
                cars[i].Age = (343 * 34 * DateTime.Now.Millisecond * 77) / DateTime.Now.Minute;
            }
            stopWatch.Stop();
            Console.WriteLine($"Default For result is \t\t{stopWatch.Elapsed}");

            stopWatch.Restart();
            Parallel.ForEach(cars, item => item.Age = (343 * 34 * DateTime.Now.Millisecond * 77) / DateTime.Now.Minute);
            stopWatch.Stop();
            Console.WriteLine($"Parallel ForEach result is \t{stopWatch.Elapsed}");

            stopWatch.Restart();
            Parallel.For(0, cars.Count, i => cars[i].Age = (343 * 34 * DateTime.Now.Millisecond * 77) / DateTime.Now.Minute);
            stopWatch.Stop();
            Console.WriteLine($"Parallel For result is \t\t{stopWatch.Elapsed}");
        }
    }
}
