using System;
namespace VirtualOverride
{
	public class Dog : Animal
	{ 
		public bool IsHappy { set; get; }

		public Dog(string name, int age):base(name, age)
		{
			IsHappy = true;

		}

        //simple everride of the virtual method
        public override void Eat()
        {
			//we must use keyword base to call method from base class
            base.Eat();
        }

        //override of the virtual method
        public override void MakeSound()
        {
            Console.WriteLine("Wuuf Wuuf!");
        }

        //override can be virtual method
        public override void Play()
        {
            if (IsHappy)
            {
                base.Play();
            }
        }
    }
}

