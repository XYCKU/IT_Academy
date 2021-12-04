using System;
using Models.NewsSections;

namespace Models
{
    public class NewsProvider
    {
        public EmergencySection EmergencySection = new EmergencySection();
        public HumorSection HumorSection = new HumorSection();
        public NewsSection NewsSection = new NewsSection();
        public SportSection SportSection = new SportSection();
        public WeatherSection WeatherSection = new WeatherSection();


    }
}
