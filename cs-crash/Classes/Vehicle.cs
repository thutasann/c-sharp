using System;

namespace MyFirstProgram
{
	abstract public class Vehicle
	{
		public int speed = 0;

		public void go()
		{
			Console.WriteLine("This vehicle is moving!");
		}
	}
}

