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

            student[] students = new student[5];
            students[0] = new student(1, "Denis", 88);
            students[1] = new student(2, "Fhg", 54);
            students[2] = new student(6, "Hjhscd", 17);
            students[3] = new student(1, "Ojcs", 95);
            students[4] = new student(4, "Bsdg", 68);

            Hashtable Table = new Hashtable();

            foreach (student s in students)
            {
                if (!Table.ContainsKey(s.Id))
                {
                    Table.Add(s.Id,s);
                    Console.WriteLine($"Student with id {s.Id} was added");
                }
                else
                {
                    Console.WriteLine("The ID already exists!");
                }
            }




        }

        /*
        static void GetStudent()
        {
            Hashtable studentTable = new Hashtable();

            student student1 = new student(1, "Maria", 76);
            student student2 = new student(2, "Olga", 46);
            student student3 = new student(3, "Janina", 88);

            //adding students to table
            studentTable.Add(student1.Id, student1);
            studentTable.Add(student2.Id, student2);
            studentTable.Add(student3.Id, student3);


            student storedStudent1 = (student)studentTable[student1.Id];


            //retrive all values from hastable
            foreach (DictionaryEntry entry in studentTable)
            {
                student temp = (student)entry.Value;
                Console.WriteLine("ID: " + temp.Id);
                Console.WriteLine("Name: " + temp.Name);
                Console.WriteLine("GPA: " + temp.GPA);
            }

            foreach (student value in studentTable.Values)
            {
                Console.WriteLine("ID: " + value.Id);
                Console.WriteLine("Name: " + value.Name);
                Console.WriteLine("GPA: " + value.GPA);
            }




            Console.WriteLine($"{storedStudent1.Id} {storedStudent1.Name} {storedStudent1.GPA}");
        }*/

    }
    class student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public student(int id, string name, float gpa)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = gpa;
        }
    }
}