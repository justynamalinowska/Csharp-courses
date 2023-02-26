using System;
namespace creating_Interfaces
{
	public class Car : Vehical, IDestroyable //auto dodajemy do zniszczalnych elementow
	{
		public string DestructionSound { get; set; }

		public List<IDestroyable> DestroyablesNearbly;


		public Car(float speed, string color) : base (speed, color)
		{

			DestructionSound = "CarExplosionSound.mp3";
			//initiate a list of destroyable objects
			DestroyablesNearbly = new List<IDestroyable>();

		}

		public void Destroy()
		{
			//when a car get destroyed we should play the destrucion sound and create fire effect

			Console.WriteLine($"Playing destruction sound {DestructionSound}");
			Console.WriteLine("Create fire");

            foreach (IDestroyable destroyable in DestroyablesNearbly)
            {
				destroyable.Destroy();
            }
        }
    }
}

