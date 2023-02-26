using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //this class is a blue print
    public class Human
    {
       //member viarable
        private string firstName = "";
        private string lastName = "";
        private string eyeColor = "";
        private int age;



    //default constracter
        public Human()
        {
            Console.WriteLine("Constructor called. Object created");
        }


        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

            //parameter constructor
            public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;

        }



        //member
        public void IntroduceMyself()
        {
            if (age!=0 && lastName != null && eyeColor!=null && firstName!=null)
            Console.WriteLine("Hi, I'm " + firstName + " " + lastName + " and I'm " + age + " years old. My eyes are " + eyeColor + ".");

            else if (lastName != null && eyeColor != null && firstName != null)
                Console.WriteLine("Hi, I'm " + firstName + " " + lastName + " and my eyes are " + eyeColor + ".");

            else if (lastName != null && firstName != null) 
            Console.WriteLine("Hi, I'm " + firstName + " " + lastName + ".");

            else if (firstName != null)
                Console.WriteLine("Hi, I'm " + firstName + ".");
        }
    }
}

