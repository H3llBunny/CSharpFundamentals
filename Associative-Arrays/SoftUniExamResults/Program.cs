using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            var students = new Dictionary<string, Dictionary<string, int>>();
            var languages = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "exam finished")
            {
                string[] command = input.Split("-");

                if (command.Length > 2)
                {
                    string username = command[0];
                    string language = command[1];
                    int points = int.Parse(command[2]);

                    bool userCheck = students.Any(x => x.Key == username);

                    if (userCheck)
                    {
                        bool languageCheck = students[username].Keys.Contains(language);

                        if (languageCheck)
                        {
                            if (students[username][language] < points)
                            {
                                students[username][language] = points;
                                languages[language]++;
                            }
                            else
                            {
                                languages[language]++;
                            }
                        }
                        else
                        {
                            students[username].Add(language, points);

                            if (languages.ContainsKey(language))
                            {
                                languages[language]++;
                            }
                            else
                            {
                                languages.Add(language, 1);
                            }
                        }
                    }
                    else if (!userCheck)
                    {
                        var tmp = new Dictionary<string, int>();
                        tmp.Add(language, points);
                        students.Add(username, tmp);

                        if (languages.ContainsKey(language))
                        {
                            languages[language]++;
                        }
                        else
                        {
                            languages.Add(language, 1);
                        }
                    }
                }
                else if (command.Length == 2)
                {
                    string username = command[0];

                    if (students.ContainsKey(username))
                    {
                        var tmp = students[username];
                        students.Remove(username);
                        students.Add("banned", tmp);
                    }
                }
            }

            Console.WriteLine("Results:");

            foreach (var student in students.OrderByDescending(x => x.Value.Values.Max()).ThenBy(x => x.Key))
            {
                if (student.Key != "banned")
                {
                    Console.WriteLine($"{student.Key} | {student.Value.Values.Max()}");
                }
            }

            Console.WriteLine("Submissions:");

            foreach (var language in languages.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}
