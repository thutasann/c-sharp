using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; // declaratin
            x = 123; // initialization

            int y = 123; // declaration + initialization

            int z = x + y;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            int age = 21;
            double height = 300.4;
            bool male = true;
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your Height is " + height);
            Console.WriteLine("Your Gender is " + male);

            char sign = '@';
            Console.WriteLine("This is sign " + sign);

            string name = "Bro code";
            Console.WriteLine("This is String" +  name);

            // constants = immutable values which are known at compile time
            // and do not change for the life of the program
            const double pi = 3.1429;
            Console.WriteLine("This is PI Value " + pi);

            // type casting = Converting a value to a different data type
            // Usefule when we accept user input (string)
            // Different data type can do different things

            double a = 3.14;
            int b = Convert.ToInt32(a);

            int c = 123;
            double d = Convert.ToDouble(c) + 12.3;

            int e = 234;
            string f = Convert.ToString(e);

            Console.WriteLine("Type of a " + a.GetType());
            Console.WriteLine("Type of b " + b.GetType());
            Console.WriteLine(b);
            Console.WriteLine(d);
            Console.WriteLine(f);

            // User Input
            //Console.WriteLine("What's your name ? ");
            //string nameInput = Console.ReadLine();

            //Console.WriteLine("What is your age ? ");
            //int ageInput = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Hello " + nameInput);
            //Console.WriteLine("Your age is " + ageInput);

            // Arithmetic Operation
            int friends = 5;
            friends += 1;
            friends++;
            Console.WriteLine("friends" + friends);

            int reminder = friends % 3;
            Console.WriteLine("reminder " + reminder);

            // Math Class
            double mathX = 3.4;
            double mathA = Math.Pow(mathX, 4);
            double mathB = Math.Sqrt(mathA);
            double mathC = Math.Abs(mathB);
            double mathD = Math.Round(mathC);
            double mathE = Math.Ceiling(mathD);
            double mathF = Math.Floor(mathE);
            double mathG = Math.Max(mathX, mathF);
            Console.WriteLine(mathG);

            // Random Class
            Random random = new Random();
            int randomNum = random.Next(1, 4);
            double randomDouble = random.NextDouble();
            Console.WriteLine("randomNum" + randomNum);
            Console.WriteLine("randomDouble" + randomDouble);


            Console.ReadKey();
        }
    }
}