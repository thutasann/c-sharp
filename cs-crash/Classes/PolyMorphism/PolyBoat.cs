using System;

namespace MyFirstProgram
{
	public class PolyBoat : PolyVehicle
	{
		public PolyBoat()
		{
		}

        public override void Go()
        {
            Console.WriteLine("The Boat is moving!");
        }
    }
}

