using Models.Attributes;
using System;
using System.Reflection;

namespace Models
{
    public static class ValidationService
    {
        public static bool Validate(object obj)
        {
            if (obj == null) return false;

            var type = obj.GetType();
            var properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);

            bool isValid = true;
            foreach (var property in properties)
            {
                foreach (ValidationAttribute attribute in property.GetCustomAttributes(typeof(ValidationAttribute)))
                {
                    if (!attribute.IsValid(property.GetValue(obj)))
                    {
                        Console.WriteLine($"{obj}: {attribute.ErrorMessage}");
                        isValid = false;
                    }
                }
            }
            return isValid;

        }
    }
}
