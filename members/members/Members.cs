using System;
using System.Diagnostics;

namespace MembersC
{
    public class Members
    {
        //member -private field
        private string memberName;
        private string jobTitle;
        private int salary;

        //member -public field / start with a capital letter
        public int age;

        public string JobTitle { get { return jobTitle; } set { jobTitle = value; } }

        //public member Method -can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
                Console.WriteLine($"Hi, my name is {memberName}, and my job title is {jobTitle}. I'm {age} years old.");
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine($"My salary is {salary}");
        }

        //constructor member
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 5000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }

        //member - finalizer - destructor
        ~Members()
        {
            //cleanup statements
            Console.WriteLine("Deconstrution od Members object");
            Debug.Write("Deconstrution od Members object");
        }
        










    }
}

