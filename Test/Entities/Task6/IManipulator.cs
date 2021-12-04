using System;

namespace Entities.Task6
{
    public interface IManipulator<T, U>
    {
        void Write(T destination, U[] items);
        U[] Read(T from);
    }
}
