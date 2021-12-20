using System;
using System.IO;

namespace _15Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fileName = "Text.txt";

            using FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read);
            using StreamWriter streamWriter = new StreamWriter(fileStream);
            StreamReader streamReader = new StreamReader(fileStream);
            streamWriter.WriteLine("Привет с первой строки");
            streamWriter.WriteLine();
            streamWriter.WriteLine("Привет с 3й строки");
            fileStream.Position = 0;
            Console.Write(streamReader.ReadToEnd());

        }
    }
}
