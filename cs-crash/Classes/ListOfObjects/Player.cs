using System;
namespace MyFirstProgram
{
	public class Player
	{
		public string userName;
		public Player(string userName)
		{
			this.userName = userName;
		}

        public override string ToString()
        {
			return userName;
        }
    }
}

