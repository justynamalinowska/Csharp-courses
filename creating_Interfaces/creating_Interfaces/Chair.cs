using System;
namespace creating_Interfaces
{
	public class Chair : Furniture, IDestroyable
	{
		public string DestructionSound { get; set; }

		public Chair(string color, string material)
		{
			this.Color = color;
			this.Material = material;
			DestructionSound = "ChairDestructionSound.mp3";
        }

		public void Destroy()
		{
			//when a chair gets destroyed we play destruction sound and spaw the destroyed chair pairs
			Console.WriteLine($"The {Color} chair was destroyed!");
			Console.WriteLine($"Playing destruction soundv {DestructionSound}");
			Console.WriteLine("Spawning chair parts");
		}
	}
}

