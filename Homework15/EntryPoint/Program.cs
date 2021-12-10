using System;
using System.IO;
using Models;

namespace EntryPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Создать файл с таймстэмпом
            FileStream fileStream = new FileStream("1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine($"I'm just created\n{DateTime.Now}");
            streamWriter.Close();
            fileStream.Close();
            */

            string path;
            try
            {
                path = Finder.FindFile("1.txt", "./texts");
            } 
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            Archivator.Archive(path);
            Console.WriteLine("Archieved successfully");
        }
    }
}

/*
1. Создать консольное приложение, которое будет принимать путь к папке и название файла.
Файл должен искаться как в данной папке, так и во всех дочерних папках (рекурсивный поиск до того момента, когда файл найден или больше нет дочерних папок).
Не использовать всякие SearchOption.AllDirectories, которые будут за вас ходить по всем подпапкам и файлы находить. Сами пишем рекурсивный поиск. 
Если файл не найден - выбросить исключение.
Если найден - Заархивировать в той же папке и вывести на консоль, что все ок и путь к новому архиву. 
*/
