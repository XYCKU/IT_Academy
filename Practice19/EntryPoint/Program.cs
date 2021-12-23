using System;
using System.Threading;
using System.Threading.Tasks;

namespace EntryPoint
{
    internal class Program
    {
        static async Task StringWriterAsync(string str, int amount)
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}");
            while (amount-- > 0)
            {
                Console.WriteLine(str);
                await Task.Delay(100);
            }
        } 
        static async Task Main(string[] args)
        {
            Console.WriteLine($"Main Thread {Thread.CurrentThread.ManagedThreadId}");
            var task1 = StringWriterAsync("first", 5);
            
            var task2 = StringWriterAsync("second", 5);
            
            await Task.WhenAll(task1, task2);
        }
    }
}
