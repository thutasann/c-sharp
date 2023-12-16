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
            Console.WriteLine("What's your name ? ");
            string nameInput = Console.ReadLine();

            Console.WriteLine("What is your age ? ");
            int ageInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello " + nameInput);
            Console.WriteLine("Your age is " + ageInput);

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

            // Hypotenuse calculator Program
            Console.WriteLine("Enter Side A: ");
            double hypoA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Side B: ");
            double hypoB = Convert.ToDouble(Console.ReadLine());
            double hypoC = Math.Sqrt((hypoA * hypoA) + (hypoB * hypoB));
            Console.WriteLine("The hypothenuse is " + hypoC);

            // String methods
            string fullName = "Bro Code";
            fullName = fullName.ToUpper();
            Console.WriteLine("fullName" + fullName);

            string phoneNumber = "123-154-144";
            phoneNumber = phoneNumber.Replace("-", "");
            Console.WriteLine("phoneNumber" + phoneNumber);

            string niceName = "Thuta Sann";
            string userName = niceName.Insert(0, "@");
            Console.WriteLine("userName" + userName);

            string uName = "thuta_sann";
            uName = uName.Substring(0, 3);
            Console.WriteLine("SubString" + uName);

            // If Statement
            Console.WriteLine("Please enter your age : ");
            int ifAge = Convert.ToInt32(Console.ReadLine());
            if(ifAge >= 18)
            {
                Console.WriteLine("You are Adult");
            } else
            {
                Console.WriteLine("You are under age");
            }

            // Switch Case
            Console.WriteLine("What day is it today?");
            string day = Convert.ToString(Console.ReadLine());

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("This is Monday");
                    break;
                case "Tuesday":
                    Console.WriteLine("This is Tuesday");
                    break;
                default:
                    Console.WriteLine(day + " is not a day");
                    break;
            }

            // Logical Operator
            Console.WriteLine("What's the temperature outside: (C)");
            double temp = Convert.ToDouble(Console.ReadLine());

            if(temp >= 10 && temp <= 25)
            {
                Console.WriteLine("This is warn outside!");
            } else if(temp >= 50 || temp <= 50)
            {
                Console.WriteLine("Do not go outsides!");
            }

            // While Loop
            Console.WriteLine("Enter your namae: ");
            string whileName = Console.ReadLine();

            while(name == "")
            {
                Console.Write("Enter your name: ");
                whileName = Console.ReadLine();
            }
            Console.WriteLine("While Name is " + whileName);

            // For loop
            for(int i = 1; i <= 10; i+=2)
            {
                Console.WriteLine(i);
            }

            // Nested Loop = Loops inside of other loop
            // Uses varys. used a lots in sorting algorithms

            Console.WriteLine("How many rows?: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many columns ? :");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the symbol : ");
            string symbol = Console.ReadLine();

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

            // Number gussing game
            Random randomGame = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            string response;

            while (playAgain)
            {
                guess = 0;
                guesses = 100;
                response = "";
                number = randomGame.Next(min, max + 1);

                while(guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + " - " + max);
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if(guess > number) {
                        Console.WriteLine(guess + " is to high!");
                    }
                    else if(guess < number)
                    {
                        Console.WriteLine(guess + " is to low!");
                    }
                    guess++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("Gusses: " + guesses);
                Console.WriteLine("Would you like to play again (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if(response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Thanks for playing!... I Guess");

            Console.ReadKey();
        }
    }
}