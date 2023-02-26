using System;
namespace EmployeesBossesTrainees
{
	public class Trainees : Employee
	{
		public int WorkingHours { get; set; }
		public int SchoolHours { get; set; }

		public Trainees()
		{
		}

		public Trainees(string name, string firstname, int salary, int workinghours, int schoolhours) :base(name,firstname,salary)
        {
			//this.Name = name;
			//this.FirstName = firstname;    base or this
			//this.Salary = salary;

			this.WorkingHours = workinghours;
			this.SchoolHours = schoolhours;

		}

		public void Learn()
		{
			Console.WriteLine($"{Name} is teaching!");
		}

        public void Work()
        {
            Console.WriteLine($"{Name} working hours are {WorkingHours}");
        }

    }
}

