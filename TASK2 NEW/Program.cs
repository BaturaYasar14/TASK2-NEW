using System;
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Console.WriteLine(Engine.Lp100Km2MPG(6.4));
            //Engine e1 = new Engine(1480, 40);
            //Engine e2 = new Engine(2000, 60, 80);

            //Car suburau = new Car("subaru", "Impreza", new Engine(2.0, 20));
            //suburau.Go(150);

            //car mercedes = new car("mercedes", "C180", new Engine(1.8, 40));
            //mercedes.GO(100);

            string CarModel, CarType;
            double EngineCapacity, TankCapacity, UserAnswer, AddFuel;
            int Distance;
             //------------collecting data from users------throw exception while collecting data------          
                Console.Write("Please insert the car type : ");                
                CarType = Console.ReadLine();

                Console.Write("Please insert the car model : ");
                CarModel = Console.ReadLine();

         //--------------------------check the Engine capcity-------------------------
            while (true)
            {
                Console.Write("Please insert Engine capacity of the car (in CC): ");
                if ((double.TryParse(Console.ReadLine(), out EngineCapacity) && (EngineCapacity > 0.5) && (EngineCapacity < 8.0)))
                    break;
                Console.WriteLine("please choose the correct value");
            }

         
                      
            while (true)
            {
                Console.Write("Please insert the capcity of the car (in litre): ");
                if ((double.TryParse(Console.ReadLine(), out TankCapacity) && (TankCapacity > 20) && (TankCapacity < 100)))
                    break;
                Console.WriteLine("please choose the correct value");
            } 

            Car NewCar = new Car(CarType, CarModel, new Engine(EngineCapacity, TankCapacity));







            while (true)
                {
                    Console.WriteLine("What do you want to do with the car ? \n(please choose one number from the following)" +
                "\n 1. Ride the car. \n 2. fuel the car \n 3. exit the program. ");
                    try
                    {
                        UserAnswer = int.Parse(Console.ReadLine());
                    break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("invalid value, please insert the correct one.");
                    }
                }

            
            if (UserAnswer == 1)
                {                
                Console.Write("How far do you need to go (in Km)?");
                Distance = int.Parse(Console.ReadLine());
                try
                {
                    NewCar.Go(Distance);

                }
                catch(Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
            }
                else if (UserAnswer == 2)
                {
                while (true)
                {
                    Console.Write("How many litre do you want to add?");
                    try
                    {
                        AddFuel = double.Parse(Console.ReadLine());
                        if (AddFuel < TankCapacity)
                        {
                            Console.WriteLine("Adding fuel in prgress.");
                        }
                        else
                            throw new ArgumentException("the fuel will split on the floor");
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("invalid value, please insert the correct one.");
                    }             
                }                   
                }
                else if (UserAnswer == 3)
                {
                    Console.WriteLine("Good Bye Knba");
                }
                else
                {
                    Console.WriteLine("UWAGA: insert the correct number.");
                }         
        }
    }
}
