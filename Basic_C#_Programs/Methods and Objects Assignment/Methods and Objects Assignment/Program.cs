using System;

namespace Methods_and_Objects_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate and initialize employee object
            Employee employee = new Employee("Sample", "Student", 123);

            //Call superclass method SayName()
            employee.SayName();
        }
    }
}
