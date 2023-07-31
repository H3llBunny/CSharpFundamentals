using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(" : ");
                string courseName = command[0];
                string studentName = command[1];

                bool doesCourseExist = courses.Any(x => x.Key == courseName);

                if (doesCourseExist)
                {
                    courses[courseName].Add((studentName));
                }
                else
                {
                    courses.Add(courseName, new List<string>());
                    courses[courseName].Add(studentName);
                }
            }

            var orderedCourses = courses.OrderByDescending(x => x.Value.Count).ToList();

            foreach (var course in orderedCourses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var student in course.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}