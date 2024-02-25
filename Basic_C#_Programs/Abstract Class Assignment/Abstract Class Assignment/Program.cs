using System;

namespace Abstract_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate an employee object
            Employee employee = new Employee("Sample", "Student");

            //call SayName() method
            employee.SayName();
        }
    }
}
