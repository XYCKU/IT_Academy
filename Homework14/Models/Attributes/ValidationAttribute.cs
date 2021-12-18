using System;

namespace Models.Attributes
{
    public abstract class ValidationAttribute : Attribute
    {
        public string ErrorMessage { get; set; }
        public abstract bool IsValid(object item);
    }
}
