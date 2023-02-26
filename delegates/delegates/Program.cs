using System;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace delegates
{
    class Program
    {
        //definding a delegate type called FilterDelegate
        public delegate bool FilterDelegate(Person p);

        public static void Main(string[] args)
        {
            //creating 4 people
            Person p1 = new Person() { Name = "Justyna", Age = 21 };
            Person p2 = new Person() { Name = "Jakub", Age = 19 };
            Person p3 = new Person() { Name = "Mateusz", Age = 32 };
            Person p4 = new Person() { Name = "Marzena", Age = 11 };

            //add the objects to a list called people
            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            DisplayPeople("Kids", people, IsMinior);
            DisplayPeople("Seniora", people, IsAdult);
            DisplayPeople("Adults", people, IsSenior);



            //ANONYMOUS METHOD
            //variable filter FilterDelegate type
            FilterDelegate filter = delegate (Person p)
            {
                return p.Age > 20 && p.Age <= 30;
            };//semilocation because we are declaring a variable 

            DisplayPeople("Between: ", people, filter);

            //We take all the people and return true
            DisplayPeople("All: ", people, delegate (Person p) { return true; }); //third parameter is anonymous method


        }
        //a method to display the list of people that passes the filter condition
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);

            foreach (Person p in people)
            {
                //checks if this person passes the filter
                if (filter(p))
                {
                    Console.WriteLine(p.Name + " " + p.Age);
                }
            }
        }

        //FILTERS

        static bool IsMinior(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age > 18;
        }

        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }
    }
}