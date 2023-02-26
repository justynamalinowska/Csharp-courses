using System;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creating_Interfaces
{
    class Program
    {
        enum Day { Mo, Tu, We, Th, Fr, Sa, Su};
        enum Month { January = 1, February, March, April, May, June, July = 12, August, September, October, November,December};
        

        public static void Main(string[] args)
        {
            Day Mo = Day.Mo;
            Day Tu = Day.Tu;
            Day We = Day.We;
            Day Th = Day.Th;
            Day Fr = Day.Fr;
            Day Sa = Day.Sa;
            Day Su = Day.Su;

            Console.WriteLine((int)Day.Mo);
            Console.WriteLine((int)Month.February);
            Console.WriteLine((int)Month.August);
        }
    }
}
