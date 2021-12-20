using System;
using System.Collections.Generic;
using Models;
using Models.NewsSections;

namespace EntryPoint
{
    internal class Program
    {
        static void A(ICollection<int> a)
        {

        }
        static void Main(string[] args)
        {
            NewsProvider newsProvider = new NewsProvider();
            Subscriber jack = new Subscriber("Jack", newsProvider.HumorSection);
            Subscriber helen = new Subscriber("Helen", new BaseSection[] { newsProvider.EmergencySection, newsProvider.WeatherSection });

            jack.Subscribe(new BaseSection[] { newsProvider.EmergencySection, newsProvider.SportSection });
            helen.Unsubscribe(newsProvider.EmergencySection);

            newsProvider.HumorSection.CreateFreshNews("Rzaka", "Smeyaka");
            Console.WriteLine();
            newsProvider.EmergencySection.CreateFreshNews("Caution", "World Starvation");
            Console.WriteLine();
            newsProvider.SportSection.CreateFreshNews("Football", "In fact blind kittens play better than russian team");
            Console.WriteLine();
            newsProvider.WeatherSection.CreateFreshNews("Weather", "Expect some sausages rain");
        }
    }
}
