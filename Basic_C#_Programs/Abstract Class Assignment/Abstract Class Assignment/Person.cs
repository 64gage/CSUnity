using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class_Assignment
{
    public abstract class Person
    {
        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Constructor
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        //abstract method
        public abstract void SayName();
    }
}
