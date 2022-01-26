using System;
using System.Collections.Generic;
using Models.Task6;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>() { new Person(0, "Jim"), new Person(1, "Tom")};
            IWriter<Person> writer = new FileWriter<Person>();
            writer.Write("list.xml", list);
            IReader<Person> reader = new FileReader<Person>();
            var result = reader.Read("list.xml");
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
