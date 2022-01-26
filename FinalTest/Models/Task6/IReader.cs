using System;
using System.Collections.Generic;

namespace Models.Task6
{
    public interface IReader<T>
    {
        IEnumerable<T> Read(string path);
    }
}
