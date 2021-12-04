using System;
using Models.NewsSections;

namespace Models
{
    public class Subscriber
    {
        private string name;
        public string Name
        {
            get => name;
            private set
            {
                name = value ?? throw new ArgumentNullException(nameof(value));
            }
        }
        public Subscriber(string name, BaseSection section)
        {
            Name = name;
            section.FreshNews += OnFreshNews;
        }
        private void OnFreshNews(object sender, NewsEventArg e)
        {
            Console.WriteLine($"{Name} has just received some news. {sender} sent them:\n{e.Header}\n{e.Text}.");
        }
    }
}
