using System;
namespace Inheritances_and_Interfaces
{
	public class Weapon
	{
		public string Name; //we don't need a constructor because there will be no parametr in method

		 public void Label()
		{
			Console.WriteLine($"This is {Name}!");
		}
	}
}

