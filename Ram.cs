using System;

namespace Garage
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram drives past. Rrrrooooaaaaarrrrr.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram stops 100 yards past the marked stopping point.");
        }
    }
}