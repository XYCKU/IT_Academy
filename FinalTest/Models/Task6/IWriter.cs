using System;
using System.Collections.Generic;

namespace Models.Task6
{
    public interface IWriter<T>
    {
        void Write(string path, IEnumerable<T> collection);
    }
}
