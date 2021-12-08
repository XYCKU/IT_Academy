using System;
using System.Text.RegularExpressions;


namespace Models.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class RegexAttribute : ValidationAttribute
    {
        private string filter;
        public string Filter
        {
            get => filter;
            private set
            {
                filter = value ?? throw new ArgumentNullException(nameof(value));
            }
        }
        public RegexAttribute() : this("^[A-Z][A-Za-z]{1,20}$") { }
        public RegexAttribute(string filter)
        {
            Filter = filter;
        }

        public override bool IsValid(object item)
        {
            string str = (item as string) ?? throw new ArgumentNullException(nameof(item));

            var result = Regex.IsMatch(str, Filter);
            if (!result)
            {
                this.ErrorMessage = string.IsNullOrEmpty(this.ErrorMessage) ? "String is not valid" : this.ErrorMessage;
            }

            return result;
        }
    }
}
