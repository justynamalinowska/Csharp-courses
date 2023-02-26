using System;
namespace Abstractclasses
{
	public abstract class Shape // we can't create objects od absract classes

		//what the object is - abstract class
		//what the object can do - interface
	{
		public string Name { get; set; }


		public Shape()
		{
		}

		public virtual void GetInfo() // we can override
		{
			Console.WriteLine($"\n This is the {Name}");
		}

		public abstract double Volume();
		


	}
}

