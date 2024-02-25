using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_and_Objects_Assignment
{
    public class Employee : Person
    {
        //Property
        public int Id { get; set; }

        // Constructor
        public Employee(string firstName, string lastName, int id) : base(firstName, lastName)
        {
            Id = id;
        }
    }
}
