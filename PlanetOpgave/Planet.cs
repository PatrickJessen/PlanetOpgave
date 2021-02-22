using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetOpgave
{
    class Planet
    {
        public string Name { get; set; }
        public double Mass { get; set; }
        public double Diameter { get; set; }
        public double Density { get; set; }
        public double Gravity { get; set; }
        public TimeSpan RotationPeriod { get; set; }
        public TimeSpan LengthOfDay { get; set; }
        public double DistanceFromSun { get; set; }
        public TimeSpan OrbitalPeriod { get; set; }
        public double OrbitalVelocity { get; set; }
        public double MeanTemperature { get; set; }
        public int NumberOfMoons { get; set; }
        public bool HasRingSystem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Name of the planet</param>
        /// <param name="mass">Mass of the planet</param>
        /// <param name="diameter">Diameter of the planet</param>
        /// <param name="density">Density of the planet</param>
        /// <param name="gravity">Gravity of the planet</param>
        /// <param name="rotationPeriod">Rotation time of the planet</param>
        /// <param name="lengthOfDay">How long is a day on that planet</param>
        /// <param name="distanceFromSun">Distance from planet to the sun</param>
        /// <param name="orbitalPeriod">Orbital Period on the planet</param>
        /// <param name="orbitalVelocity">Orbital Velocity of the planet</param>
        /// <param name="meanTemperature">Temperature on the planet</param>
        /// <param name="numberOfMoons">How many moons does the planet have</param>
        /// <param name="hasRingSystem">Does the planet have any ring systems?</param>
        public Planet(string name, double mass, double diameter, double density, double gravity, TimeSpan rotationPeriod, TimeSpan lengthOfDay, double distanceFromSun, TimeSpan orbitalPeriod, double orbitalVelocity, double meanTemperature, int numberOfMoons, bool hasRingSystem)
        {
            Name = name;
            Mass = mass;
            Diameter = diameter;
            Density = density;
            Gravity = gravity;
            RotationPeriod = rotationPeriod;
            LengthOfDay = lengthOfDay;
            DistanceFromSun = distanceFromSun;
            OrbitalPeriod = orbitalPeriod;
            OrbitalVelocity = orbitalVelocity;
            MeanTemperature = meanTemperature;
            NumberOfMoons = numberOfMoons;
            HasRingSystem = hasRingSystem;

        }
    }
}
