using System;
namespace Polymorphic_Parameters
{
	public class Car
	{
		public int HP { get; set; }
		public string Color { get; set; }

		//has a relationship
		protected CarIdInfo carIdInfo = new CarIdInfo();

		public void SetCarIdInfo(int idNum,string owner)
		{
			carIdInfo.IDnum = idNum;
			carIdInfo.Owner = owner;
		}

		public void GetCarIdinfo()
		{
			Console.WriteLine($"The car has the Id od {carIdInfo.IDnum} and is owned by {carIdInfo.Owner}");
		}


		public Car()
		{ }

		public Car(int hp, string color)
		{
			this.HP = hp;
			this.Color = color;
		}

		public void ShowDetails()
		{
			Console.WriteLine($"HP: {HP}");
			Console.WriteLine($"Color: {Color}");
		}

		public virtual void Repair() //that allows us to override method
		//public sealed void Repair() that don't allow us to override method
        {
			Console.WriteLine("Car was repaired!");
		}
	}
}

