using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    internal class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }

            public Person(string name, string Id, int age)
            {
                Name = name;
                ID = Id;
                Age = age;
            }
        }
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string input;
            while((input = Console.ReadLine()) != "End")
            {
                string[] person = input.Split(" ");

                people.Add(new Person(person[0], person[1], int.Parse(person[2])));
            }

            people = people.OrderBy(x => x.Age).ToList();

            foreach(Person person in people)
            {
                Console.WriteLine(string.Join(Environment.NewLine, person.Name + " with ID: " + person.ID + " is " + person.Age + " years old."));
            }
        }
    }
}