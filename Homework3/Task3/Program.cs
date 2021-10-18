using System;
using System.Collections.Generic;

namespace Task3
{
	class Program
	{
        static int GCD(int a, int b)
        {
            if (a == 0) {
                return b;
            } else {
                int min = Math.Min(a, b);
                int max = Math.Max(a, b);
                return GCD(max - min, min);
            }
        }
        static void Main(string[] args)
		{
            List<int> list = new List<int>();

            Console.WriteLine("Input a number");
            int input = Int32.Parse(Console.ReadLine());
            while (input != 0) {
                list.Add(input);
                Console.WriteLine("Input a number");
                input = Int32.Parse(Console.ReadLine());
            }

            int answer = 0;
            if (list.Count > 0) {
                answer = list[0];
                if (list.Count > 1) {
                    for (int i = 1; i < list.Count && answer != 1; i++) {
                        answer = GCD(answer, list[i]);
                    }
                }
			}

            Console.WriteLine($"GCD = {answer}");
		}
	}
}
