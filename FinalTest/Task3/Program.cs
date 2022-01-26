using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    internal class Program
    {
        static IEnumerable<int> Method(IEnumerable<int> collection) {
            return collection.OrderBy(x => x).Skip(collection.Count() / 2).Select(x => x * x).OrderByDescending(x => x).ToArray();
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[random.Next(10) + 1];
            Console.WriteLine($"Amount: {array.Length}");
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = random.Next(20);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

            var result = Method(array);
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
