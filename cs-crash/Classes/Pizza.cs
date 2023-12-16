using System;

namespace MyFirstProgram
{
	public class Pizza
	{
		string bread;
		string sauce;
		string cheese;
		string topping;

		public Pizza(string bread, string sauce, string cheese, string topping)
		{
			this.bread = bread;
			this.sauce = sauce;
			this.cheese = cheese;
			this.topping = topping;
		}
		public Pizza(string bread, string sauce)
		{
			this.bread = bread;
			this.sauce = sauce;
		}
	}
}

