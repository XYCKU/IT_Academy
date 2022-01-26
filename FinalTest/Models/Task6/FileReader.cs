using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Models.Task6
{
    public class FileReader<T> : IReader<T> where T : Person
    {
        private static XmlSerializer xml = new XmlSerializer(typeof(T[]));
        public IEnumerable<T> Read(string path)
        {
            using var stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
            return (IEnumerable<T>)xml.Deserialize(stream);
        }
    }
}
