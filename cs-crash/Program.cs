using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cycles = new string[3];
            string name = "Thuta";

            cycles[0] = "Bike 1";
            cycles[1] = "Bike 2";
            cycles[2] = "Bike 3";

            foreach(string cycle in cycles)
            {
                Console.WriteLine(cycle);
            }

            // METHODS
            static void HappyBirthday(string name)
            {
                Console.WriteLine("Happy birthday" + name);
            }
            HappyBirthday(name);


            double x;
            double y;
            double result;

            Console.WriteLine("Enter Number 1 : ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Number 2 : ");
            y = Convert.ToDouble(Console.ReadLine());

            result = Multiply(x, y);
            Console.WriteLine(result);

            
            Multiply(3, 4);


            // Method overloading = methods share same name, but differnet params
            // name + parameters = signature
            // methods must have a unique signature
            double total;
            total = Multiply(2, 3, 4);
            Console.WriteLine(total);
            
        }

        static double Multiply(double x, double y)
        {
            double z = x * y;
            return z;
        }
        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }
    }
}