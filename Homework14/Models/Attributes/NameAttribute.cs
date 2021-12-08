using System;
using System.ComponentModel.DataAnnotations;
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
            string name = (item as string) ?? throw new ArgumentNullException(nameof(item));

            var result = Regex.IsMatch(name, Filter);
            if (!result)
            {
                this.ErrorMessage = string.IsNullOrEmpty(this.ErrorMessage) ? "napisesh suda" : this.ErrorMessage;
            }

            return result;
        }
    }
}
