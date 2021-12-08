using System;
using System.Reflection;
using System.Text.RegularExpressions;
using Models.Attributes;

namespace Models
{
    public class Person
    {
        private string firstName, lastName;
        private int age;
        [Name]
        public string FirstName
        {
            get => firstName;
            private set
            {
                firstName = value ?? throw new ArgumentNullException(nameof(value));
            }
        }
        [Name]
        public string LastName {
            get => lastName;
            private set
            {
                lastName = value ?? throw new ArgumentNullException(nameof(value));
            }
        }
        [Age(5, 26)]
        public int Age 
        {
            get => age;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                age = value;
            }
        }
        public Person() : this("No name", "No family", 0){ }
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public bool IsValid()
        {
            var type = this.GetType();
            var properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);

            foreach(var property in properties)
            {
                foreach(var attribute in property.GetCustomAttributes())
                {
                    var nameAttr = attribute as NameAttribute;
                    if (nameAttr != null)
                    {
                        if (!nameAttr.IsValid(property.GetValue(this) as string)) {
                            return false;
                        }
                        continue;
                    }
                    var ageAttr = attribute as AgeAttribute;
                    if (ageAttr != null)
                    {
                        if (!ageAttr.IsValid((int)property.GetValue(this))) {
                            return false;
                        }
                        continue;
                    }
                }
            }
            return true;
        }
    }
}
