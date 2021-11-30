using System;
using Models;

namespace EntryPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NewsProvider newsProvider = new NewsProvider();
            Subscriber jack = new Subscriber("Jack", newsProvider.HumorSection);
            Subscriber helen = new Subscriber("Helen", newsProvider.EmergencySection);
            Subscriber mark = new Subscriber("Mark", newsProvider.SportSection);
            Subscriber bob = new Subscriber("Robert", newsProvider.SportSection);

            newsProvider.HumorSection.CreateFreshNews("Rzaka", "Smeyaka");
            Console.WriteLine();
            newsProvider.EmergencySection.CreateFreshNews("Caution", "World Starvation");
            Console.WriteLine();
            newsProvider.SportSection.CreateFreshNews("Football", "In fact blind kittens play better than russian team");
        }
    }
}
