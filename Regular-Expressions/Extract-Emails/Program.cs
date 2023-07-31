using System;
using System.Text.RegularExpressions;

namespace Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var regex = new Regex(@"(^|(?<=\s))[a-z](([\.]?|[-]?|[_]?|[a-z]?)[a-z]+)+@[a-z](([-]?|[a-z]+)+[\.][a-z]([-]?|[\.]?|[a-z])[a-z]+)+(\b|(?=\s))");
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
