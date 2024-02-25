using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class_Assignment
{
    public class Employee : Person, IQuittable
    {
        //Constructor
        public Employee(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        //implement Quit method from IQuittable interface
        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} is quitting the job.");
        }

        //implement abstract method
        public override void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
