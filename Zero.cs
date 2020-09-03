using System;
namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
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