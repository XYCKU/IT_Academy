using System;
using System.Text.RegularExpressions;

namespace Models.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class NameAttribute : ValidationAttribute
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
        public NameAttribute() : this("^[A-Z][A-Za-z]{1,20}$") { }
        public NameAttribute(string filter)
        {
            Filter = filter;
        }
        public override bool IsValid(object item)
        {
            string name = (item as string)?? throw new ArgumentNullException(nameof(item));
            return Regex.IsMatch(name, Filter);
        }
    }
}
