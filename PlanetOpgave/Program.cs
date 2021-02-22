using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Planet> planets = new List<Planet>();
            List<Planet> planetsBellowZero = new List<Planet>();
            List<Planet> PlanetsWithDiameter = new List<Planet>();
            planets.Add(new Planet("Mekur", 0.330, 4879, 5427, 3.7, TimeSpan.FromHours(1407.6), TimeSpan.FromHours(4222.6), 57.9, TimeSpan.FromDays(88.0), 47.4, 167, 0, false));
            planets.Add(new Planet("Venus", 4.87, 12.104, 5243, 8.9, TimeSpan.FromHours(-5832.5), TimeSpan.FromHours(2802.0), 108.2, TimeSpan.FromDays(224.7), 35.0, 464, 0, false));
            planets.Add(new Planet("Earth", 5.97, 12.756, 5514, 9.8, TimeSpan.FromHours(23.9), TimeSpan.FromHours(24.0), 149.6, TimeSpan.FromDays(365.2), 29.8, 15, 1, false));
            planets.Add(new Planet("Mars", 0.642, 6792, 3933, 3.7, TimeSpan.FromHours(24.6), TimeSpan.FromHours(24.7), 227.9, TimeSpan.FromDays(687.0), 24.1, -65, 2, false));
            planets.Add(new Planet("Jupiter", 1898, 142.984, 1326, 23.1, TimeSpan.FromHours(9.9), TimeSpan.FromHours(9.9), 778.6, TimeSpan.FromDays(4331), 13.1, -110, 67, true));
            planets.Add(new Planet("Saturn", 568, 120.536, 687, 9.0, TimeSpan.FromHours(10.7), TimeSpan.FromHours(10.7), 1433.5, TimeSpan.FromDays(10.747), 9.7, -140, 62, true));
            planets.Add(new Planet("Uranus", 86.8, 51.118, 1271, 8.7, TimeSpan.FromHours(-17.2), TimeSpan.FromHours(17.2), 2872.5, TimeSpan.FromDays(30.589), 6.8, -195, 27, true));
            planets.Add(new Planet("Neptun", 102, 49.528, 1638, 11.0, TimeSpan.FromHours(16.1), TimeSpan.FromHours(16.1), 4495.1, TimeSpan.FromDays(58.8), 5.4, -200, 14, true));
            planets.Add(new Planet("Pluto", 0.0146, 2370, 2095, 0.7, TimeSpan.FromHours(-153.3), TimeSpan.FromHours(153.3), 5906.4, TimeSpan.FromDays(90.56), 4.7, -225, 5, false));

            for (int i = 0; i < planets.Count; i++)
            {
                if (planets[i].Name == "Pluto")
                {
                    planets.RemoveAt(i);
                }
            }

            planets.Add(new Planet("Pluto", 0.0146, 2370, 2095, 0.7, TimeSpan.FromHours(-153.3), TimeSpan.FromHours(153.3), 5906.4, TimeSpan.FromDays(90.56), 4.7, -225, 5, false));
            foreach (Planet planet in planets)
            {
                if (planet.HasRingSystem == true)
                {
                    Console.WriteLine($"{planet.Name}, {planet.Mass}, {planet.Diameter}, {planet.Density}, {planet.Gravity}, {planet.RotationPeriod}, {planet.LengthOfDay}, {planet.DistanceFromSun}, {planet.OrbitalPeriod}, {planet.OrbitalVelocity}, {planet.MeanTemperature}, {planet.NumberOfMoons}, Yes");
                }
                else
                {
                    Console.WriteLine($"{planet.Name}, {planet.Mass}, {planet.Diameter}, {planet.Density}, {planet.Gravity}, {planet.RotationPeriod}, {planet.LengthOfDay}, {planet.DistanceFromSun}, {planet.OrbitalPeriod}, {planet.OrbitalVelocity}, {planet.MeanTemperature}, {planet.NumberOfMoons}, No");
                }
                if (planet.MeanTemperature <= 0)
                {
                    planetsBellowZero.Add(planet);
                }
                if (planet.Diameter > 10000 && planet.Diameter < 50000)
                {
                    PlanetsWithDiameter.Add(planet);
                }
            }
            for (int i = 0; i < planetsBellowZero.Count; i++)
            {
                Console.WriteLine(planetsBellowZero[i].Name);
            }
            Console.WriteLine(planets.Count);
            for (int i = 0; i < planets.Count; i++)
            {
                planets.RemoveAt(i);
            }

            Console.ReadKey();
        }
    }
}
