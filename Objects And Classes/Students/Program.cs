using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    internal class Program
    {
        public class Student
        {
            public string FirstName { get; set; }
            public string SecondName { get; set; }
            public double Grade { get; set; }

            public Student (string firstName, string secondName, double grade)
            {
                FirstName = firstName;
                SecondName = secondName;
                Grade = grade;
            }

            public override string ToString()
            {
                return $"{FirstName} {SecondName}: {Grade:f2}";
            }
        }

        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            string[] input;

            for (int i = 0; i < studentsCount; i++)
            {
                input = Console.ReadLine().Split(' ');
                students.Add(new Student(input[0], input[1], double.Parse(input[2])));
            }

            students = students.OrderByDescending(x => x.Grade).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, students));
        }
    }
}