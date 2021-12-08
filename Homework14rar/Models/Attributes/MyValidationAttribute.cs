using System;
using System.ComponentModel.DataAnnotations;

namespace Models.Attributes
{
    public abstract class MyValidationAttribute : ValidationAttribute
    {
        public abstract ValidationResult Validate(object item);
    }
}
