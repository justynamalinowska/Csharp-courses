using System;
namespace Polymorphic_Parameters
{
	public class Audi : Car
	{
        public string Model { get; set; }
		private string Brand;

        public Audi()
        { }

        public Audi(string model, int hp, string color) : base (hp, color)
		{
			Brand = "Audi";
			this.Model = model;
		}

        public void ShowDetails()
        {
            Console.WriteLine($"HP: {HP}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
        }

        public override void Repair() //that allows us to override method
        {
            Console.WriteLine($"{Model} was repaired!");
        }
    }
}

