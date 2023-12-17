using System;

namespace MyFirstProgram
{
	public class Hawk : IPredator
	{
		public Hawk()
		{
		}

        public void Hunt()
        {
            Console.WriteLine("The Hawk is searching for the food");
        }
    }
}

