using System;
namespace EmployeesBossesTrainees
{
	public class Employee
	{
		public string Name { set; get; }
        public string FirstName { set; get; }
		public int Salary { set; get; }

		public Employee()
		{
			Name = "null";
			FirstName = "null";
			Salary = 0;
		}

        public Employee(string name, string firstname, int salary)
		{
			this.Name = name;
			this.FirstName = firstname;
			this.Salary = salary;
		}

		public void Work()
		{
			Console.WriteLine($"{Name} is working");
		}

		public void Stop()
		{
			Console.WriteLine($"{Name} is stopping");
        }
	}
}

