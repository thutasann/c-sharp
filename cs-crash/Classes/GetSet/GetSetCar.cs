using System;

namespace MyFirstProgram
{
	public class GetSetCar
	{

		private int speed;

		public GetSetCar(int speed)
		{
			Speed = speed;
		}

		public int Speed
		{
			get { return speed; } // read
			set
			{
				if(value > 500)
				{
					speed = 500;
				}
				else
				{
                    speed = value;
                }
			}
		}
	}
}

