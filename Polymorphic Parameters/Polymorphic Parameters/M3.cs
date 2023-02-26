using System;
namespace Polymorphic_Parameters
{
	public class M3 : BMW
	{


        public M3(string model, int hp, string color) : base(model, hp, color)
        {
            this.Model = model;
        }

        public override void Repair()
        {
            base.Repair();
        }
    }
}

