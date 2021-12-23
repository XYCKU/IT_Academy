using System;
using System.Threading.Tasks;
using Models;

namespace EntryPoint
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Matrix matrix = new Matrix(20, 10);
            for (int i = 0; i < 200; ++i)
            {
                await matrix.CycleAsync();
            }
        }   
    }
}
