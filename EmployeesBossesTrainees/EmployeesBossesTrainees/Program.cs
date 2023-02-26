using System;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesBossesTrainees
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee("Burek", "Jakub", 4000);
            Boss boss = new Boss("Malinowska", "Justyna", 10000000, "Audi");
            Trainees trainees = new Trainees("Malinowski", "Mateusz", 4000, 100, 80);

            boss.Lead();
            trainees.Work();
        }
    }
}