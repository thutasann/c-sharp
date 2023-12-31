﻿using System;

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


            // static = modifier to declare a static member, which belongs to the class itself
            // rather than to any specific object
            Cycle cycle1 = new("Cycle 1");
            Cycle cycle2 = new("Cycle 2");
            Console.WriteLine(cycle1.numberOfCars);
            Console.WriteLine(cycle2.numberOfCars);
            cycle1.Race();

            // overload constructor = technique to creat multiple constructors,
            // with a different set of parameters
            // name + parameter = signature
            Pizza pizza = new("stuffed crust", "red sauce");
            Console.WriteLine(pizza);

            // Inheritance = 1 or more child classes
            // receiving fields, methods etc. from a common parent
            // Abstract Classes = modifier that indicates missing components or incomplete implementation
            // Vehicle vehicle = new Vehicle(); // <-- abstract
            ChildCar childCar = new();
            ChildCarTwo childCarTwo = new();
            ChildCarThree childCarThree = new();

            childCar.go();
            Console.WriteLine(childCarTwo.speed);
            Console.WriteLine(childCarThree.wheels);

            // Array of Objects
            //ObjCar[] garage = new ObjCar[3];
            //ObjCar objCar = new("Obj Car one");
            //ObjCar objCarTwo = new("Obj Car two");
            //ObjCar objCarThree = new("Obj car three");
            //garage[0] = objCar;
            //garage[1] = objCarTwo;
            //garage[2] = objCarThree;

            //foreach(ObjCar objCarItem in garage)
            //{
            //    Console.WriteLine(objCarItem.model);
            //}

            // Objects as arguments
            ObjCar objCar = new("Mustage", "red");
            ChangeColor(objCar, "blue");
            Console.WriteLine(objCar.color + " " + objCar.model);

            ObjCar objCar1 = Copy(objCar);
            Console.WriteLine("ojbCar1 " + objCar1.color + " " + objCar1.model);

            // Method Overriding = provides a new version of a method inherited
            // from a parent class inherited method must be : abstract, virtual, or already
            // overriden used with ToString(), ploymorphism
            Dog dog = new();
            Cat cat = new();
            dog.Speak();
            cat.Speak();

            // ToString()
            ObjCar objCarToString = new("Modal", "Red");
            Console.WriteLine(objCarToString.ToString());

            // Polymorphism = Greek word that means to "have many forms"
            // Objects can be identified by more than one type
            // Ex. A Dog is also: Canine, Animal, Organism
            PolyCar polyCar = new();
            PolyBicycle polyBicycle = new();
            PolyBoat polyBoat = new();

            PolyVehicle[] polyVehicles = { polyCar, polyBicycle, polyBoat };

            foreach(PolyVehicle polyVehicle in polyVehicles)
            {
                polyVehicle.Go();
            }


            // Interface = defines a "contract" that all the classes inheriting from
            // should follow
            // An interface declares "what a class should have"
            // An inheriting class defines "how it should do it"
            // Benefit = security + multiple inheritance + "plug-and-play"

            Rabbit rabbit = new();
            rabbit.Flee();
            Hawk hawk = new();
            hawk.Hunt();
            Fish fish = new();
            fish.Flee();
            fish.Hunt();

            // List = data structure that respresents a list of objects that can be accessed by index.
            // Similar to array, but can dynamically increase/decrease in size
            // using System.Collections.Generic.

            List<string> foods = new()
            {
                "Pizza",
                "Hamburger",
                "Hotdog"
            };

            foreach (string food in foods)
            {
                Console.WriteLine(food);
            }

            // List of Objects
            List<Player> players = new();
            Player player1 = new Player("chad one");
            Player player2 = new Player("chad two");
            Player player3 = new Player("chad threee");

            players.Add(player1);
            players.Add(player2);
            players.Add(player3);

            foreach(Player player in players)
            {
                Console.WriteLine("Player " + player);
            }

            // Getters and Setters = add securit to fields by encapsulation
            // They're accessors found within properties
            // properties = combines aspects of both fields and methods (share name with a field)
            // get accessor = used to return the property value
            // set accessor = use to assign a new value
            // value keyword =  defiens the value being assinged by the set (parameter)

            GetSetCar getSetCar = new(400);
            getSetCar.Speed = 50999;
            Console.WriteLine("GetCar speed " + getSetCar.Speed);


            // Auto-Implemented properties = shortcut when no additional logic is required in the property
            // you do not have to define a field for a peoperty,
            // you only have to write get; and/or set; inside the property
            GetSetCarTwo getSetCarTwo = new("Porsche");
            Console.WriteLine(getSetCarTwo.Model);


            // Enums = special "class" that contains a set of named integer constants
            // Use enums when you have values that you know will not change.
            // To get the integer value from an item, you muse explicitly convert to an int

            Console.WriteLine(Planets.Pluto + " is a planet # " + (int)Planets.Pluto);

            string name = PlanetRadius.Earth.ToString();
            int radius = (int)PlanetRadius.Earth;
            double volume = Volume(PlanetRadius.Earth);
            Console.WriteLine("Planet: " + name);
            Console.WriteLine("Radius : " + radius);
            Console.WriteLine("Volume: " + volume);

            // Genesric = "not specific to a particular data type
            // add <T> to : classes, methods, fields, etc.
            // allows for code reusability for different data types
            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.2, 0.3, 3.3 };
            string[] stringArray = { "1", "2", "3" };
            DisplayElments(intArray);
            DisplayElments(doubleArray);
            DisplayElments(stringArray);

            // Thread = an execution path of a program
            // We can use multiple threads to perform,
            // different tasks of our program at the same time.
            // Current thread running is "main" thread using Sytem.Threading.
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";

            Thread thread1 = new(() => CountUp("Timer #1"));
            Thread thread2 = new(() => CountDown("Timer #2"));
            thread1.Start();
            thread2.Start();

            Console.WriteLine(mainThread.Name + " is completed!");


            Console.ReadKey();

        }

        public static void ChangeColor(ObjCar car, string color)
        {
            car.color = color;
        }

        public static ObjCar Copy(ObjCar objCar)
        {
            return new ObjCar(objCar.model, objCar.color);
        }

        public static double Volume(PlanetRadius radius)
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
            return volume;
        }

        /// <summary>
        /// Generic Display Element
        /// </summary>
        /// <param name="array"></param>
        public static void DisplayElments<T>(T[] array)
        {
            foreach(T item in array)
            {
                Console.WriteLine("IntArray " + item);
            }
        }

        /// <summary>
        /// CountDown Func
        /// </summary>
        public static void CountDown(string name)
        {
            for(int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #1: " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine(name + " is complete");
        }

        /// <summary>
        /// CountUp Func
        /// </summary>
        public static void CountUp(string name)
        {
            for(int i = 0; i <= 10; i ++)
            {
                Console.WriteLine("Timer #2: " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine(name + " is complete");

        }
    }

    
    
}