using System;

namespace MyFirstProgram
{
	class Cycle
	{
		string model;
		public int numberOfCars;
		public static int age;

		public Cycle(string model)
		{
			this.model = model;
			numberOfCars++;
		}

		public void Race()
		{
			Console.WriteLine("The race has begun!");
		}

		public static void StaticRace()
		{
			Console.WriteLine("The static Race has begun!");
		}
	}
}

