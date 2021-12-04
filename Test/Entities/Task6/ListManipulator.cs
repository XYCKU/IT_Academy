using System;
using System.Collections.Generic;

namespace Entities.Task6
{
    public class ListManipulator<T> : IManipulator<List<T>, T>
    {
        public T[] Read(List<T> from)
        {
            return from.ToArray();
        }
        public void Write(List<T> destination, T[] items)
        {
            destination.AddRange(items);
        }
    }
}
