using System;
using System.Threading;

namespace Task2
{
    class Car
    {
        private string make;
        private string model;
        private Engine engine;
        public Car(string newMake, string newModel, double newDisplacement,
                   double newAmountOfFuel, double newFuelTankCapacity) :
            this(newMake, newModel, new Engine(newDisplacement, newAmountOfFuel, newFuelTankCapacity))
        { }
        public Car(string newMake, string newModel, double newDisplacement,  double newAmountOfFuel) :
            this(newMake, newModel, new Engine(newDisplacement, newAmountOfFuel))
        { }

        public Car(string newMake, string newModel, Engine newEngine)
        {
            this.make = newMake;
            this.model = newModel;
            this.engine = newEngine;
        }
        public void Go(double howManyKm)
        {
            Console.WriteLine("I'm riding");
            int OffSet = 0;
            while (howManyKm > 0)
            {
                Console.SetCursorPosition(OffSet, Console.CursorTop);
                OffSet++;
                //Console.Write("Distance to ride: {0,4}", howManyKm);
                Console.Write("--//-0----0-\\--");
                this.engine.Work();
                Thread.Sleep(100);
                howManyKm--;
            }
            Console.WriteLine("\nHere I am");
        }
    }
}