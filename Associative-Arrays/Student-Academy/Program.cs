using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Academy;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            double grade = double.Parse(Console.ReadLine());

            bool studentChecker = students.Any(x => x.Key == name);

            if (studentChecker)
            {
                students[name].Add(grade);
            }
            else
            {
                students.Add(name, new List<double>());
                students[name].Add(grade);
            }
        }

        Dictionary<string, double> filteredStudents = new Dictionary<string, double>();

        foreach (var student in students)
        {
            double sumGrade = 0;

            foreach (var grade in student.Value)
            {
                sumGrade += grade;
            }

            if (sumGrade / student.Value.Count >= 4.50)
            {
                filteredStudents.Add(student.Key, (sumGrade / student.Value.Count));
            }
        }

        foreach (var student in filteredStudents.OrderByDescending(x => x.Value))
        {
            Console.WriteLine($"{student.Key} -> {student.Value:f2}");
        }
    }
}