using System;
using System.Collections.Generic;
using Entities.Task6;

namespace TestTask6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] items = { 5, 4, 3, 2, 5, 3, 2 };
            Stack<int> stack = new Stack<int>(items);
            List<int> list = new List<int>(items);

            StackManipulator<int> stackManip = new StackManipulator<int>();
            stackManip.Write(stack, new int[]{ 6, 6, 6 } );
            int[] stackOutput = stackManip.Read(stack);
            Console.WriteLine($"Stack: {String.Join(", ", stack.ToArray())}");


            ListManipulator<int> listManip = new ListManipulator<int>();
            listManip.Write(list, new[] { 0, 0, 0, 1 });
            int[] listOutput = listManip.Read(list);
            Console.WriteLine($"List: {String.Join(", ", list.ToArray())}");


        }
    }
}
