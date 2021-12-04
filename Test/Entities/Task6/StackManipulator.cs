using System;
using System.Collections.Generic;

namespace Entities.Task6
{
    public class StackManipulator<T> : IManipulator<Stack<T>, T>
    {
        public T[] Read(Stack<T> from)
        {
            return from.ToArray();
        }
        public void Write(Stack<T> destination, T[] items)
        {
            foreach(var item in items)
            {
                destination.Push(item);
            }
        }
    }
}
