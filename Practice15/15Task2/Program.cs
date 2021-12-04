using System;
using System.IO;

namespace _15Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fileName = "Text.txt";

            FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine("Привет с первой строки");
            streamWriter.WriteLine();
            streamWriter.WriteLine("Привет с 3й строки");

            streamWriter.Flush();

            StreamReader streamReader = new StreamReader(fileStream);
            fileStream.Position = 0;
            Console.Write(streamReader.ReadToEnd());
            streamReader.Close();
        }
    }
}
