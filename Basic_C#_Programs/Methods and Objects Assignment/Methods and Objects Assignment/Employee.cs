using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_and_Objects_Assignment
{
    public class Employee : Person
    {
        //Property
        public int Id { get; set; }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (ReferenceEquals(employee1, employee2))
                return true;

            if (employee1 is null || employee2 is null)
                return false;

            return employee1.Id == employee2.Id;
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2);
        }

        // Constructor
        public Employee(string firstName, string lastName, int id) : base(firstName, lastName)
        {
            Id = id;
        }
    }
}
