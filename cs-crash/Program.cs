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
        }
    }
}