using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "BMW", "Mustang", "Corvette" };
            cars[0] = "BMW Updated";

            for(int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            string[] cycles = new string[3];

            cycles[0] = "Bike 1";
            cycles[1] = "Bike 2";
            cycles[2] = "Bike 3";

            for(int i = 0; i < cycles.Length; i++)
            {
                Console.WriteLine(cycles[i]);
            }

            foreach(string cycle in cycles)
            {
                Console.WriteLine(cycle);
            }
        }
    }
}