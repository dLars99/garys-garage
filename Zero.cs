using System;
namespace Garage
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero crawls by. It makes no sound.");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Zero appears to be attempting a {direction} turn.");
        }
        public override void Stop()
        {
            Console.WriteLine("The Zero does not stop. It was never moving to begin with.");
        }

    }
}