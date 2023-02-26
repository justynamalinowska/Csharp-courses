using System;
namespace EmployeesBossesTrainees
{
	public class Boss : Employee
	{
		public string CompanyCar { get; set; }

		public Boss()
		{
		}

        public Boss(string name, string firstname, int salary, string companycar) //insted of writting those 3 linies we can use base
        {
            this.Name = name;
            this.FirstName = firstname;
            this.Salary = salary;

            this.CompanyCar = companycar;
        }

        public void Lead()
        {
            Console.WriteLine($"{Name} is leading");
        }
    }
}

