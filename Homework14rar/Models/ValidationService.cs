using Models.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Models
{
    public static class ValidationService
    {
        public static bool Validate<TAttributeClass>(object obj) where TAttributeClass : MyValidationAttribute
        {
            if (obj == null) return false;
            
            var type = obj.GetType();
            var properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);

            bool isValid = true;
            foreach (var property in properties)
            {
                foreach (var attribute in property.GetCustomAttributes<TAttributeClass>())
                {
                    var validationResult = attribute.Validate(property.GetValue(obj));
                    if (validationResult != ValidationResult.Success)
                    {
                        Console.WriteLine($"{obj}: {validationResult.ErrorMessage}");
                        isValid = false;
                    }
                }
            }
            return isValid;
            
        }
    }
}
