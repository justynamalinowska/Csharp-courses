using System;
namespace IEnumerator_and_IEnumerable
{
	public class Dog
	{
		public string Name { get; set; }
		public bool IsNaughtyDog { get; set; }

		public Dog(string name, bool isnaughtydog)
		{
			this.Name = name;
			this.IsNaughtyDog = isnaughtydog;
		}

		public void GiveTreat(int numberoftrats)
		{
			Console.WriteLine($"Dog {Name} said wuoff {numberoftrats} times!");
		}
	}
}

