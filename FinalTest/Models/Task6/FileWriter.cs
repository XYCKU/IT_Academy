using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Models.Task6
{
    public class FileWriter<T> : IWriter<T> where T : Person
    {
        private static XmlSerializer xml = new XmlSerializer(typeof(T[]));
        public void Write(string path, IEnumerable<T> collection)
        {
            using var stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            xml.Serialize(stream, collection.ToArray());
        }
    }
}
