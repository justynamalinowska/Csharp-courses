using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    //blueprint for datatype
    public class Human
    {
        //member viarable

        private string firstName = "No name";
        private string lastName = "No last name";
        private string eyeColor = "No eye color";
        private int age;

        //constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }





        //member method
        public void IntroduceMyself()
        {
            if(age==1)
                Console.WriteLine($"Hi I'm {firstName} {lastName}. I have {eyeColor} eyes and {age} year.");
            else
            Console.WriteLine($"Hi I'm {firstName} {lastName}. I have {eyeColor} eyes and {age} years.");
        }

    }
}

