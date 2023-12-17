using System;

namespace MyFirstProgram
{
	public class Fish : IPredator, IPrey
	{
		public Fish()
		{
		}

        public void Flee()
        {
            Console.WriteLine("Fish FLee");
        }

        public void Hunt()
        {
            Console.WriteLine("Fish Hunt");
        }
    }
}

