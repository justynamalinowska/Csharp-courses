using System;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        public static void Main(string[] args)
        {
            Ticket ticket1 = new Ticket(50);
            Ticket ticket2 = new Ticket(50);
            Console.WriteLine(ticket2.Equals(ticket1));
            
        }
    }
}
