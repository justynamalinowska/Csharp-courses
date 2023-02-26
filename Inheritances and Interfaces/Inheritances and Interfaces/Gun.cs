using System;
namespace Inheritances_and_Interfaces
{
	public class Gun : Weapon, IShootable
	{
		
		public Gun()
		{
			Name = "Gun";
		}

		public void Shoot()
		{
			Console.WriteLine("Bang!");
		}
	}
}

