using System;

namespace Models.NewsSections
{
    public abstract class BaseSection
    {
        public event EventHandler<NewsEventArg> FreshNews;
        protected virtual void OnFreshNews(NewsEventArg args)
        {
            FreshNews?.Invoke(this, args);
        }
        public void CreateFreshNews(string header, string text)
        {
            NewsEventArg args = new NewsEventArg(header, text);
            OnFreshNews(args);
        }
    }
}
