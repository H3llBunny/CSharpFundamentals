using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace SoftUniCoursePlanning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> courses = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] command = new string[] { };

            while ((command = Console.ReadLine().Split(':').ToArray())[0] != "course start")
            {
                if (command.Contains("Add") && courses.Contains(command[1]) != true && courses.Contains(command[1] + "-Exercise") != true)
                {
                    courses.Add(command[1]);
                }

                else if (command.Contains("Insert") && courses.Contains(command[1]) != true)
                {
                    if (courses.Contains(command[1] + "-Exercise") != true)
                    {
                        courses.Insert(int.Parse(command[2]), command[1]);
                    }
                }

                else if (command.Contains("Remove") && courses.Contains(command[1]) == true)
                {
                    courses.Remove(command[1]);
                    courses.Remove(command[1] + "-Exercise");
                }

                else if (command.Contains("Swap") && courses.Contains(command[1]) && courses.Contains(command[2]))
                {
                    if (courses.Contains(command[1] + "-Exercise") != true && courses.Contains(command[2] + "-Exercise") != true)
                    {
                        int firstIndex = courses.IndexOf(command[1]);
                        int secondIndex = courses.IndexOf(command[2]);
                        string tmp = courses[firstIndex];
                        courses[firstIndex] = courses[secondIndex];
                        courses[secondIndex] = tmp;
                    }

                    else if (courses.Contains(command[1] + "-Exercise") == true && courses.Contains(command[2] + "-Exercise") == true)
                    {
                        int firstIndex = courses.IndexOf(command[1]);
                        int firstExcercise = courses.IndexOf(command[1] + "-Exercise");
                        int secondIndex = courses.IndexOf(command[2]);
                        int secondExercise = courses.IndexOf(command[2] + "-Exercise");
                        string tmp = courses[firstIndex];
                        string tmpExercise = courses[firstExcercise];
                        courses[firstIndex] = courses[secondIndex];
                        courses[firstExcercise] = courses[secondExercise];
                        courses[secondIndex] = tmp;
                        courses[secondExercise] = tmpExercise;
                    }

                    else if (courses.Contains(command[1] + "-Exercise") != true && courses.Contains(command[2] + "-Exercise") == true)
                    {
                        int firstIndex = courses.IndexOf(command[1]);
                        int secondIndex = courses.IndexOf(command[2]);
                        string tmp = courses[firstIndex];
                        courses[firstIndex] = courses[secondIndex];
                        courses[secondIndex] = tmp;
                        int indexExercise = courses.IndexOf(command[2] + "-Exercise");
                        string tmpExercise = courses[indexExercise];
                        courses.RemoveAt(indexExercise);
                        courses.Insert(courses.IndexOf(command[2]) + 1, tmpExercise);
                    }

                    else if (courses.Contains(command[1] + "-Exercise") == true && courses.Contains(command[2] + "-Exercise") != true)
                    {
                        int firstIndex = courses.IndexOf(command[1]);
                        int secondIndex = courses.IndexOf(command[2]);
                        string tmp = courses[secondIndex];
                        courses[secondIndex] = courses[firstIndex];
                        courses[firstIndex] = tmp;
                        int indexExercise = courses.IndexOf(command[1] + "-Exercise");
                        string tmpExercise = courses[indexExercise];
                        courses.RemoveAt(indexExercise);
                        courses.Insert(courses.IndexOf(command[1]) + 1, tmpExercise);
                    }
                }

                if (command.Contains("Exercise"))
                {
                    if (courses.Contains(command[1]) != true && courses.Contains(command[1] + "-" + command[0]) != true)
                    {
                        courses.Add(command[1]);
                        courses.Add((command[1] + "-" + command[0]));
                    }

                    else if (courses.Contains(command[1]) == true && courses.Contains(command[1] + "-" + command[0]) != true)
                    {
                        int index = courses.IndexOf(command[1]);
                        courses.Insert(index + 1, command[1] + "-" + command[0]);
                    }
                }
            }

            for (int i = 1; i <= courses.Count; i++)
            {
                Console.WriteLine(i + "." + courses[i - 1]);
            }
        }
    }
}