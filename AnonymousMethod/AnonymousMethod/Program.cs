using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AnonymousMethod
{
    class Program
    {
        public delegate bool FilterDelegate(Person P);

        public static void Main(string[] args)
        {
            Person p1 = new Person("Justyna", 21);
            Person p2 = new Person("Aga", 13);
            Person p3 = new Person("Mateusz", 20);
            Person p4 = new Person("Marzena", 43);


            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            
            DisplayPeople("Kids: ", people, IsMinior);
            DisplayPeople("Adults: ", people, IsAdult);
            DisplayPeople("Seniors: ", people, IsSenior);
            

            FilterDelegate filter = delegate (Person p)
            {
                return p.Age >= 20 && p.Age < 30;

            };

            DisplayPeople("Between 20 and 30: ", people, filter);

            DisplayPeople("All: ", people, delegate (Person p) { return true; });


            //statement lambda
            string searchKeyword = "a";
            DisplayPeople("age >20 with search keyword" + searchKeyword, people, (p) =>
            {
                if (p.Name.Contains(searchKeyword) && p.Age >20)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            });

            DisplayPeople("exactly 25", people, p => p.Age == 25);

        }



        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
            {
                Console.WriteLine(title);

                foreach (Person p in people)
                {
                Console.WriteLine(p);
                }
            }

        static bool IsMinior(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }
        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }
        
    }
}
