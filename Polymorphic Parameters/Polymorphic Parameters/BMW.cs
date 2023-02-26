using System;
namespace Polymorphic_Parameters
{
    //bmw is a car
	public class BMW : Car
	{
		public string Model { get; set; }
        private string Brand = "BMW";

        public BMW()
        {}

        public BMW(string model, int hp, string color) : base(hp, color)
        {
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

