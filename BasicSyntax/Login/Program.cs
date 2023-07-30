using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class DebugLogin
    {
        static void Main()
        {
            string user = Console.ReadLine();
            string password = Console.ReadLine();
            for (int i = 0; i <= 3; i++)
            {
                if (i == 3)
                {
                    if (user == ReverseString(password))
                    {
                        Console.WriteLine("User {0} logged in.", user);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("User {0} blocked!", user);
                    }
                }

                else if (user == ReverseString(password))
                {
                    Console.WriteLine("User {0} logged in.", user);
                    break;
                }

                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    password = Console.ReadLine();
                }
            }
        }

        private static string ReverseString(string password)
        {
            char[] arr = password.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}