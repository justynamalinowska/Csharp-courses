using System;
using System.Xml.Linq;

namespace Parameters
{
    public class Program
    {

        //array as a parameter

        static void Main(string[] args)
        {
            int[] happiness = new int[] { 1, 2, 3, 4, 5 };

            foreach (int happy in happiness)
            {
                Console.WriteLine(happy);
            }

            Increase(happiness);

            foreach (int happy in happiness)
            {
                Console.WriteLine(happy);
            }

        }

        static void Increase(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 2;
            }
        }





        static void ShowGrades()
        {
            int[] studentsGrades = new int[] { 5, 3, 6, 2, 1, 1, 5, 2, 4 };
            double averageResult = GetAverage(studentsGrades);

            foreach (int grade in studentsGrades)
            {
                Console.WriteLine(grade);
            }

            Console.WriteLine($"The average is {averageResult}");
        }

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }

            average = (double)sum / size;
            return average;
        }

        //challenge
        static void FamillyAndFriends()
        {
           string[][] FriendsAndFamilly = new string[][]
               {
                new string[]{"Cam", "Michael"},
                new string[]{"Gloria", "Jay"},
                new string[]{"Alex", "Phil"}
               };

            Console.WriteLine($"Hi ours names are {FriendsAndFamilly[0][0]} and {FriendsAndFamilly[0][1]}.");
            Console.WriteLine($"Hi ours names are {FriendsAndFamilly[1][0]} and {FriendsAndFamilly[1][1]}.");
            Console.WriteLine($"Hi ours names are {FriendsAndFamilly[2][0]} and {FriendsAndFamilly[2][1]}.");
        }
    }
}