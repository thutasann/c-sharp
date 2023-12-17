using System;

namespace MyFirstProgram
{
	public class PolyCar : PolyVehicle
	{
		public PolyCar()
		{
		}

		public override void Go()
		{
			Console.WriteLine("The car is moving!");
		}
	}
}

