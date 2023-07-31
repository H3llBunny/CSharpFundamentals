using System;
using System.Linq;
using System.Collections.Generic;

namespace CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var companies = new Dictionary<string, List<string>>();
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var tokens = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string companyName = tokens[0];
                string employeeID = tokens[1];

                if (companies.ContainsKey(companyName))
                {
                    if (!companies[companyName].Contains(employeeID))
                    {
                        companies[companyName].Add(employeeID);

                    }
                }
                else
                {
                    companies.Add(companyName, new List<string> { employeeID });
                }
            }

            foreach (var company in companies.OrderBy(x => x.Key))
            {
                Console.WriteLine(company.Key);

                foreach (var user in company.Value)
                {
                    Console.WriteLine($"-- {user}");
                }
            }
        }
    }
}