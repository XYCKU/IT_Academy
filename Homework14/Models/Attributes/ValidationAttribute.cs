using System;

namespace Models.Attributes
{
    public abstract class ValidationAttribute : Attribute
    {
        public abstract bool IsValid(object item);
    }
}
