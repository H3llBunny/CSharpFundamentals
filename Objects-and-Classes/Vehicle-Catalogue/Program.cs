using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    internal class Program
    {
        public class Catalogue
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public double Horsepower { get; set; }

            public Catalogue(string type, string model, string color, double horsepower)
            {
                Type = type;
                Model = model;
                Color = color;
                Horsepower = horsepower;
            }
        }

        static void Main(string[] args)
        {
            string input;
            List<Catalogue> catalogue = new List<Catalogue>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] vehicle = input.Split(' ');

                catalogue.Add(new Catalogue(vehicle[0].Substring(0, 1).ToUpper() + vehicle[0].Substring(1), vehicle[1], vehicle[2], double.Parse(vehicle[3])));
            }

            string command;

            while ((command = Console.ReadLine()) != "Close the Catalogue")
            {
                bool doesModelExist = catalogue.Any(x => x.Model.Contains(command));

                if (doesModelExist)
                {
                    int index = catalogue.FindIndex(x => x.Model == command);

                    Console.WriteLine(string.Join(Environment.NewLine, "Type: " + catalogue[index].Type, "Model: " + catalogue[index].Model, 
                        "Color: " + catalogue[index].Color, "Horsepower: " + catalogue[index].Horsepower));
                }
            }

            if(catalogue.Count > 0)
            {
                double carHpSum = 0;
                double carCount = 0;
                double truckHpSum = 0;
                double truckCount = 0;

                foreach (Catalogue vehicle in catalogue)
                {
                    if (vehicle.Type == "Car")
                    {
                        carHpSum += vehicle.Horsepower;
                        carCount++;
                    }
                    else if (vehicle.Type == "Truck")
                    {
                        truckHpSum += vehicle.Horsepower;
                        truckCount++;
                    }
                }

                double avgCarHp = carHpSum / carCount;
                double avgTruckHp = truckHpSum / truckCount;

                if (carCount > 0)
                {
                    Console.WriteLine($"Cars have average horsepower of: {avgCarHp:f2}.");
                }
                else
                {
                    Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
                }
                if (truckCount > 0)
                {
                    Console.WriteLine($"Trucks have average horsepower of: {avgTruckHp:f2}.");
                }
                else
                {
                    Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
                }
            }
        }
    }
}