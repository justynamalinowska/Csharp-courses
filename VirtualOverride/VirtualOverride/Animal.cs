using System;
namespace VirtualOverride
{
	public class Animal
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public bool IsHungry { get; set; }

		public Animal(string name, int age)
		{
			Name = name;
			Age = age;
			IsHungry = true;
		}


		//virtual can be override

		public virtual void MakeSound()
		{

		}

		public virtual void Eat()
		{
			if (IsHungry)
            {
				Console.WriteLine($"mniam mniam, {Name} is eating");
				IsHungry = false;
			}
			else
			{
				Console.WriteLine($"{Name} is not hungry :(");
			}

        }

		public virtual void Play()
		{
			Console.WriteLine($"{Name} is playing");
		}
	}
}

