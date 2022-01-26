using System;

namespace Task1_
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Random random = new Random();
            int size = 7;
            int[,] array = new int[size, size];
            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    array[i, j] = random.Next(100);
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < size; ++i)
            {
                for (int j = i + 1; j < size; ++j)
                {
                    array[i, j] = 1;
                }
            }

            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }

        }
    }
}
