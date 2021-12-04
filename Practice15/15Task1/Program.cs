using System;
using System.IO;

namespace _15Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @".\Folders";
            DirectoryInfo directory = new DirectoryInfo(path);

            if (!directory.Exists)
            {
                directory.Create();
            }

            DirectoryInfo[] directories = new DirectoryInfo[20];
            for(int i = 0; i < directories.Length; i++)
            {
                directories[i] = directory.CreateSubdirectory($"MyTestFolder{i}");
            }

            for(int i = 0; i < directories.Length; i++)
            {
                directories[i].Delete();
            }
            
        }
    }
}
