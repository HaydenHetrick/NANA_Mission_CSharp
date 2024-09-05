using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaMissionToTheMoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight = 15000; //kg
            double distanceToMoon = 384400; //km
            double fuel = CalculateFuel(weight, distanceToMoon);
            Console.WriteLine("Fuel needed: " + fuel + " kg");

            string status = CheckMissionStatus(100000, true);
            Console.WriteLine(status);

            status = CheckMissionStatus(100000, false);
            Console.WriteLine(status);

            status = CheckMissionStatus(99999, true);
            Console.WriteLine(status);

            Console.ReadKey();
        }

        public static double CalculateFuel(double weight, double distance)
        {
            double fuelNeeded = weight * distance * 0.05;
            return fuelNeeded;
        }

        public static string CheckMissionStatus(double fuelLevel, bool crewReady)
        {
            if (fuelLevel < 100000)
            {
                return "Mission failed: Not enough fuel";
            }
            else if (!crewReady)
            {
                return "Mission failed: Crew not ready";
            }
            else
            {
                return "Mission is ready.";
            }
        }
    }
}
