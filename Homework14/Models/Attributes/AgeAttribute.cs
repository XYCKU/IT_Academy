using System;
using System.ComponentModel.DataAnnotations;

namespace Models.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class AgeAttribute : MyValidationAttribute
    {
        private int minAge, maxAge;
        public int MinAge
        {
            get => minAge;
            private set
            {
                minAge = (value >= 0)? value : throw new ArgumentOutOfRangeException(nameof(value));
            }
        }
        public int MaxAge
        {
            get => maxAge;
            private set
            {
                maxAge = (value >= 0) ? value : throw new ArgumentOutOfRangeException(nameof(value));
            }
        }

        public AgeAttribute() : this(0, 150) { }
        public AgeAttribute(int minAge, int maxAge)
        {
            MinAge = minAge;
            MaxAge = maxAge;
        }
        public override ValidationResult Validate(object item)
        {
            int age = (int)item;
            return (age >= minAge && age <= maxAge)? ValidationResult.Success : new ValidationResult(ErrorMessage);
        }
    }
}
