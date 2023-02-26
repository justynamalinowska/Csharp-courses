using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2001, 12, 11);
            Console.WriteLine($"My birthday is {dateTime}");

            //write today on screen
            Console.WriteLine(DateTime.Today);

            //write current time on screen
            Console.WriteLine(DateTime.Now);

            Console.WriteLine($"Today is {DateTime.Today.DayOfWeek}");

            Console.WriteLine(GetFirstDayOfYear(2001));


            DateTime tomorrow = GetTomorrow();
            Console.WriteLine($"Tomorrow will be the {tomorrow}");

            int days = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine("Dyas in Feb 2000 " + days );


            DateTime now = DateTime.Now;
            Console.WriteLine($"Hours: {now.Hour} Minutes: {now.Minute} Seconds: {now.Second}");



            Console.WriteLine("Write your birthday date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine($"You are {daysPassed.Days} days old");
            }
            else
            {
                Console.WriteLine("Wrong input!!");
            }

        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}