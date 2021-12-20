using System;
using System.IO;
using Newtonsoft.Json;

namespace _15Task3
{          
    internal class Program
    {
        static void Main(string[] args)
        {
            MyItem item = new MyItem(5, "Jack");

            using (FileStream fileStream = new FileStream("MyItem.json", FileMode.Create, FileAccess.ReadWrite))
            using (StreamWriter streamWriter = new StreamWriter(fileStream))
            {
                var json = JsonConvert.SerializeObject(item);
                streamWriter.WriteLine(json);
                streamWriter.Flush();

                fileStream.Position = 0;
                StreamReader streamReader = new StreamReader(fileStream);
                MyItem item2 = JsonConvert.DeserializeObject<MyItem>(streamReader.ReadToEnd());
            }
        }
    }
}
