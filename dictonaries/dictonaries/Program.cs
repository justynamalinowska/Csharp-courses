using System;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsKeyword
{
    public class Program
    {

        static void Main(string[] args)
        {
            Employee[] employees=
            {
                new Employee("CEO", "Justyna", 21, 200),
                new Employee("intern", "Magda", 30, 20),
                new Employee("hr", "Mateusz", 19, 43),
                new Employee("secretary", "Jakub", 22, 43),
            };


            Dictionary<int, string> myDictonary = new Dictionary<int, string>()
            {
                //key - value
                {1, "one" },
                {2, "two" },
                {3, "three" }
            };
            Dictionary<string, Employee> employeesDictonary = new Dictionary<string, Employee>();


            foreach (Employee emp in employees)
            {
                employeesDictonary.Add(emp.Name, emp);
            };




            //who is the CEO?
            Employee empl1 = employeesDictonary["Justyna"];
            Console.WriteLine(empl1.Name + " " + empl1.Salary + " " + empl1.Age);

            //trygetvalue
            Employee result = null;

            if (employeesDictonary.TryGetValue("Mateusz", out result)) //jezeli jest ktos o iminiu mateusz przypisuje jego dane do pracownika result
            {
                Console.WriteLine("retrived");

                Console.WriteLine("name: " + result.Name);
                Console.WriteLine("age: " + result.Age);
            }
            else
            {
                Console.WriteLine("The key does not exist");
            }

            //we want to update a specific key
            string keytoupdate = "Mateusz";
            if (employeesDictonary.ContainsKey(keytoupdate))
            {
                employeesDictonary[keytoupdate] = new Employee("hr", "Ela", 26, 23);

            }
            else
            {
                Console.WriteLine("There is nobody");
            }

            //remove
            string stringtoremove = "Magda";
            if (employeesDictonary.Remove(stringtoremove))
            {
                Console.WriteLine($"Emploee {stringtoremove} was removed");
            }
            else
            {
                Console.WriteLine("There is nobody");
            }






            for (int i = 0; i < employeesDictonary.Count; i++)
            {
                //using ElementAt(i) to return the key-value pair stored at index i
                KeyValuePair<string, Employee> keyValuePair = employeesDictonary.ElementAt(i);
                //print the key
                Console.WriteLine("Key: " + keyValuePair.Key + "i: " + i);
                //storing a value in employee object
                Employee emplyeeValue = keyValuePair.Value;
                //printing the propeties of the employee object
                Console.WriteLine(emplyeeValue.Name);
                Console.WriteLine(emplyeeValue.Age);
                Console.WriteLine(emplyeeValue.Role);
            }


        }
    }
    class Employee
    {
        //few properities
        public string Name { get; set; }
        public int Age { get; set; }
        public string Role { get; set; }
        public float Rate { get; set; }

        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 4;
            }
        }

        public Employee(string Role, string Name, int Age, float Rate)
        {
            this.Role = Role;
            this.Name = Name;
            this.Age = Age;
            this.Rate = Rate;



        }
    }
}
