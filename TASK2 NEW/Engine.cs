using System;
namespace Task2
{
    class Engine
    {

        private const double mileOfMile = 1.609344;         // per km
        private const double Gallon = 3.785411784;    // per ltr
        private readonly double Displacement;
        private const double DefaultFuelTankCapacity = 50;
        //private readonly double defaultFuelTankCapacity = 50;
        private readonly double FuelTankCapacity;
        private double amountOfFuel;
        public Engine(double newDisplacement, double newAmountOfFuel)
        {
            this.Displacement = newDisplacement;
            this.amountOfFuel = newAmountOfFuel;
            this.FuelTankCapacity = DefaultFuelTankCapacity;
        }
        public Engine(double newDisplacement, double newAmountOfFuel,
            double newFuelTankCapacity):this(newDisplacement,newAmountOfFuel)
        {
            this.FuelTankCapacity = newFuelTankCapacity;
        }
        public static double MPG2Lp100Km(double MPG)
        {
            return (100 * Gallon) / (mileOfMile * MPG);
        }
        public static double Lp100Km2MPG(double Lp100Km)
        {
            return (100 * Gallon) / (mileOfMile * Lp100Km);
        }
        public void Work()
        {
            this.amountOfFuel -= (4* this.Displacement) / 100;
            if (this.amountOfFuel <= 0)
                throw new InvalidOperationException("I'm dry");            
        }

        public void Refuel(double FuelAmout)
        {
            if (this.amountOfFuel + FuelAmout > this.FuelTankCapacity)
                throw new ArgumentException("Fuel on shoe");
                this.amountOfFuel += FuelAmout;
            Console.ReadKey();
        }

    }
}
