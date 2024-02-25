using System;

namespace Methods_and_Objects_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate and initialize employee object
            Employee employee1 = new Employee("John", "Doe", 123);
            Employee employee2 = new Employee("Jane", "Doe", 124);

            if (employee1 == employee2)
            {
                Console.WriteLine("Employees have the smae Id.");
            }
            else
            {
                Console.WriteLine("Employees have different Ids.");
            }

            //Call superclass method SayName()
            employee1.SayName();
        }
    }
}
