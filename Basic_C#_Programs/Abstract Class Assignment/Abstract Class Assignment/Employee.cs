using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class_Assignment
{
    public class Employee : Person
    {
        //Constructor
        public Employee(string firstName, string lastName) : base(firstName, lastName)
        {

        }

        //implement abstract method
        public override void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
