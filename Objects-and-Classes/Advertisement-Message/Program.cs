using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Phrases = { "Excellent product.", "Such a great product.",
                    "I always use that product.",
                    "Best product of its category.",
                    "Exceptional product.", "I can’t live without this product." };

            string[] Events = { "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!" };

            string[] Authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] Cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int number = int.Parse(Console.ReadLine());

            Random rnd = new Random();

            for (int i = 0; i < number; i++)
            {
                int phraseIndex = rnd.Next(Phrases.Length);
                int eventIndex = rnd.Next(Events.Length);
                int authorIndex = rnd.Next(Authors.Length);
                int cityIndex = rnd.Next(Cities.Length);

                Console.WriteLine($"{Phrases[phraseIndex]} {Events[eventIndex]} {Authors[authorIndex]} - {Cities[cityIndex]}");
            }
        }
    }
}