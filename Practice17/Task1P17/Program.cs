using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Task1P17
{
    internal class Program
    {
        static Mutex mutex = new Mutex(false, "StreamMutex");
        static string Read(string from)
        {
            mutex.WaitOne();

            string result = string.Empty;
            using (FileStream fileStream = new FileStream(from, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite))
            using (StreamReader reader = new StreamReader(fileStream))
            {
                result = reader.ReadToEnd();
            }
            mutex.ReleaseMutex();
            return result;
        }
        static void Write(string to, string text)
        {
            mutex.WaitOne();
            using (FileStream fileStream = new FileStream(to, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            using(StreamWriter writer = new StreamWriter(fileStream))
            {
                var task1 = new Task<string>(() => Read(to));
                task1.Start();
                task1.Wait();
                string result = $"{task1.Result}{text}";

                writer.WriteLine(result);
            }
            mutex.ReleaseMutex();
        }
        static void Main(string[] args)
        {
            var task1 = new Task<string>(() => Read("1.txt"));
            var task2 = new Task<string>(() => Read("2.txt"));
            task1.Start();
            task2.Start();

            task1.Wait();
            task2.Wait();

            Task task3 = new Task(() => Write("3.txt", $"{task1.Result}"));
            task3.Start();
            task3.Wait();

            Task task4 = new Task(() => Write("3.txt", $"{task2.Result}"));
            task4.Start();
            task4.Wait();
            
            Console.WriteLine(Read("3.txt"));
        }
    }
}
