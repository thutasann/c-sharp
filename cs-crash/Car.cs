using System;

namespace MyFirstProgram
{
	public class Car
	{
		public string make;
		public string model;
		public int year;
		public string color;

		public Car(string make, string model, int year, string color)
		{
			this.make = make;
			this.model = model;
			this.year = year;
			this.color = color;
		}

		public void Drive()
		{
			Console.WriteLine("You drive the " + make + " " + model);
		}
	}
}

