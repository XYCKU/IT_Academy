using System;
using Entities;

namespace TestTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack stack = new MyStack();
            for (int i = 0; i < 100; i++)
            {
                stack.Push(i);
            }
            while(stack.Count > 0)
            {
                stack.Pop();
            }
        }
    }
}
