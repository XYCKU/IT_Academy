using System;
using System.Reflection;
using Models;
using Models.Attributes;

namespace EntryPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[]{ new Person("Jack", "Sparrow", 22),
                                                new Person("helen", "Smith", 49), 
                                                new Person("Arthur", "Morgan", 36), 
                                                new Person("jim", "Hopper", 10), 
                                                new Person("Karen", "cardona", 16), 
                                                new Person("John", "Marston", 26)};

            foreach(var person in persons)
            {
                Console.WriteLine($"{person} is {ValidationService.Validate<MyValidationAttribute>(person)}");
                Console.WriteLine();
            }
        }
    }
}
