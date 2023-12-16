using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ford = { "Mustang", "F-150", "Explorer" };
            string[] chevy = { "chevy1", "chevy2", "chevy3" };
            string[] toyota = { "Corolla", "Camery", "Rav4" };

            string[,] parkingLot = {
                { "Mustang", "F-150", "Explorer" },
                { "chevy1", "chevy2", "chevy3" },
                { "Corolla", "Camery", "Rav4" }
            };
            parkingLot[0, 2] = "Fusion";
            parkingLot[1, 0] = "chevy2 updated";

            for(int i = 0; i < parkingLot.GetLength(0); i++)
            {
                for(int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.WriteLine(parkingLot[i, j] + " ");
                }
                Console.WriteLine();
            }

            // object = An instance of a class
            // A class can be used as a blueprint to create objects (OOP)
            // objects can have fields & methods (characteristics & actions)
            Messages.Hello();
            Human human = new("Thuta", 21);
            human.Eat();

            Human human2 = new("John", 23);
            human2.Sleep();

            Car car = new("Ford", "Mustang", 2022, "red");
            car.Drive();

            Console.ReadKey();
        }

    }
    
}