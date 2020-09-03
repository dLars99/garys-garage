using System;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }
        public virtual void Drive()
        {
            Console.WriteLine($"The {MainColor} vehicle drives by. Vrooom!");
        }
        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The vehicle turns {direction}.");
        }
        public virtual void Stop()
        {
            Console.WriteLine("All motion has ceased, by your command.");
        }
    }
}