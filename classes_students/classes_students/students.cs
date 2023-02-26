using System;
using classes_students;

namespace classes_students
{
	public class students
	{
		
        public string name;
        public string major;
        public int gpa;


        //easier way to asign the objects
        public students(string aname, string amajor, int agpa)
        {
            name = aname;
            major = amajor;
            gpa = agpa;
            Console.WriteLine("student created");
        }

        //method
        public bool Honor()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            else
                return false;
        }
	}
}

