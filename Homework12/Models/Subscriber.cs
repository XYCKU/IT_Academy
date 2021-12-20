using System;
using System.Collections.Generic;
using Models.NewsSections;

namespace Models
{
    public class Subscriber
    {
        private string name;
        private List<BaseSection> subscriptions;
        public string Name
        {
            get => name;
            private set
            {
                name = value ?? throw new ArgumentNullException(nameof(value));
            }
        }
        public Subscriber(string name)
        {
            Name = name;
            subscriptions = new List<BaseSection>();
        }
        public Subscriber(string name, BaseSection section) : this(name)
        {
            Subscribe(section);
        }
        public Subscriber(string name, ICollection<BaseSection> sections) : this(name)
        {
            Subscribe(sections);
        }
        public void Subscribe(BaseSection section)
        {
            if (subscriptions.Contains(section)) return;
            subscriptions.Add(section);
            section.FreshNews += OnFreshNews;
        }
        public void Subscribe(ICollection<BaseSection> sections)
        {
            foreach (var item in sections)
            {
                Subscribe(item);
            }
        }
        public void Unsubscribe(BaseSection section)
        {
            if (!subscriptions.Remove(section)) return;
            section.FreshNews -= OnFreshNews;
        }
        public void Unsubscribe(ICollection<BaseSection> sections)
        {
            foreach (var item in sections)
            {
                Unsubscribe(item);
            }
        }
        private void OnFreshNews(object sender, NewsEventArg e)
        {
            Console.WriteLine($"{Name} has just received some news. {sender} sent them:\n{e.Header}\n{e.Text}.");
        }
    }
}
