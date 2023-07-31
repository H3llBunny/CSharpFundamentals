using System;
using System.Collections.Generic;
using System.Linq;

namespace ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            string specialChars = @"\|' '!#$%&/()=?»«@£§€{}.;'<>,";

            foreach (var user in usernames)
            {
                if(user.Length >= 3 && user.Length <= 16)
                {
                    bool checker = true;

                    foreach (var item in specialChars)
                    {
                        if (user.Contains(item))
                        {
                            checker = false;
                        }
                    }
                    if (checker)
                    {
                        Console.WriteLine(user);
                    }
                }
            }
        }
    }
}