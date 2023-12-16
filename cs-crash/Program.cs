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

    }

    
    
}