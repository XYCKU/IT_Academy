using System;
using System.Text.RegularExpressions;

namespace Models.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class NameAttribute : Attribute
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
        public bool IsValid(string name)
        {
            return Regex.Match(name, Filter).Success;
        }
    }
}
