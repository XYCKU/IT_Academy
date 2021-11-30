using System;

namespace Models
{
    public class NewsEventArg : EventArgs
    {
        private string header, text;
        public string Header
        {
            get => header;
            private set
            {
                header = value ?? throw new ArgumentNullException(nameof(value));
            }
        }
        public string Text
        {
            get => text;
            private set
            {
                text = value ?? throw new ArgumentNullException(nameof(value));
            }
        }
        public NewsEventArg(string header, string text)
        {
            Header = header;
            Text = text;
        }
    }
}
