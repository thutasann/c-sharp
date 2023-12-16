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

            double totalParma = CheckOut(2.34, 4.24, 423.5);
            Console.WriteLine(totalParma);

            // Exception
            double exX;
            double exY;
            double exResult;

            try
            {
                Console.WriteLine("Enter number 1: ");
                exX = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter number 2: ");
                exY = Convert.ToDouble(Console.ReadLine());

                exResult = exX / exY;
                Console.WriteLine("Exresult: " + exResult);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter only NUMBERS pls " + e);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You can't divide by zero" + e);
            }

            // Conditional Operator
            double temperature = 20;
            string conditionalMessage;
            conditionalMessage = (temperature > 25) ? "It is warn outside" : "It is cold outside";
            Console.WriteLine(conditionalMessage);
            
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
        static double CheckOut(params double[] prices)
        {
            double total = 0;
            foreach(double price in prices)
            {
                total += price;
            }
            return total;
        }
    }
}