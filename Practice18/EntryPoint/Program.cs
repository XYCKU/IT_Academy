using System;
using System.Collections.Generic;
using System.Linq;

namespace EntryPoint
{
    internal class Program
    {
        public class Car
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }
        public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int CarId { get; set; }
        }
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach(var item in collection)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        static void Task1(int[] array)
        {
            Console.WriteLine("Task1");
            var query = array.Where(x => x > 0);
            PrintCollection(query);
        }
        static void Task2(int[] array)
        {
            Console.WriteLine("Task2");
            var query = array.Where(x => Math.Abs(x) % 2 == 1).Distinct();
            PrintCollection(query);
        }
        static void Task3(int[] array)
        {
            Console.WriteLine("Task3");
            var query = array.Where(x => x % 2 == 0 && x < 0).Reverse();
            PrintCollection(query);
        }
        static void Task4(int[] array)
        {
            Console.WriteLine("Task4");
            var query = array.Where(x => x >= 10 && x <= 99).OrderBy(x => x);
            PrintCollection(query);
        }
        static void Task5(IEnumerable<Car> cars, IEnumerable<Customer> customers)
        {
            Console.WriteLine("Task5");
            var query = from customer in customers.OrderBy(x => x.Name).GroupBy(x => x.Name).Select(x => x.First())
                                                    .GroupBy(x => x.CarId).Select(x => x.First())
                        join car in cars
                        on customer.CarId equals car.Id
                        orderby customer.Name
                        select new
                        {
                            CustomerName = customer.Name,
                            CustomerCar = car.Name
                        };
            foreach(var item in query)
            {
                Console.WriteLine($"Customer {item.CustomerName} bought {item.CustomerCar}.");
            }
        }
        static void Task6(IEnumerable<Car> cars, IEnumerable<Customer> customers)
        {
            Console.WriteLine("Task6");
            var query = from customer in customers.OrderBy(x => x.Name).GroupBy(x => x.CarId).Select(x => x.First())

                        join car in cars
                        on customer.CarId equals car.Id
                        orderby customer.Name
                        select new
                        {
                            CustomerName = customer.Name,
                            CustomerCar = car.Name
                        };
            foreach (var item in query)
            {
                Console.WriteLine($"Customer {item.CustomerName} bought {item.CustomerCar}.");
            }
        }
        static void Main(string[] args)
        {
            var array = new[] { 11, -20, -5, 4, 5, 8, -1, 9, 2, 0, -11, 15, 3, -3, 4, 0, 20 };
            var cars = new List<Car> {
                new Car
                {
                    Id = 1,
                    Name = "BMW",
                    Age = 5
                },
                new Car
                {
                    Id = 2,
                    Name = "Audi",
                    Age = 15
                },
                new Car
                {
                    Id = 3,
                    Name = "Dodge",
                    Age = 1
                },
                new Car
                {
                    Id = 4,
                    Name = "Ford",
                    Age = 8
                }
            };
            var customers = new List<Customer> {
                new Customer
                {
                    Name = "John",
                    Id = 1,
                    CarId = 2
                },
                new Customer
                {
                    Name = "Mark",
                    Id = 2,
                    CarId = 1
                },
                new Customer
                {
                    Name = "Lewis",
                    Id = 3,
                    CarId = 3
                },
                new Customer
                {
                    Name = "Danny",
                    Id = 4,
                    CarId = 4
                },
                new Customer
                {
                    Name = "Danny",
                    Id = 5,
                    CarId = 1
                },
            };
            Task1(array);
            Task2(array);
            Task3(array);
            Task4(array);
            Task5(cars, customers);
            Task6(cars, customers);
        }
    }
}
