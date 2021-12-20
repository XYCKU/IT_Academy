using System;
using System.IO;

namespace _15Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var str = "Hi, my name is tist file";
            using FileStream fileStream = new FileStream("TestFile.txt", FileMode.Create, FileAccess.ReadWrite);
            using StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine(str);
            Console.WriteLine(str);
            streamWriter.Flush();
            int pos = str.IndexOf("tist");
            fileStream.Position = pos;
            streamWriter.Write("test");
            streamWriter.Flush();

            fileStream.Position = 0;
            StreamReader streamReader = new StreamReader(fileStream);
            Console.WriteLine(streamReader.ReadToEnd());
            
        }
    }
}
