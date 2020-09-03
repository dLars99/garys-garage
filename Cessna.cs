using System;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flies over. Meeeeeuuuurrrhhhhhh!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Cessna gently rolls to the {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine("Planes can't just stop. The Cessna plummets from the sky.");
        }

    }
}