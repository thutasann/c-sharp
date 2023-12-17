using System;

namespace MyFirstProgram
{
	public class ObjCar
	{
		public string model;
		public string color;

		public ObjCar(string model, string color)
		{
			this.model = model;
			this.color = color;
		}

        public override string ToString()
        {
			return "This is a " + model + " " + color;
        }
    }
}

