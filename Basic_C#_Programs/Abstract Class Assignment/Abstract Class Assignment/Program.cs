using System;

namespace Abstract_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate an employee object
            Employee employee = new Employee("Sample", "Student");

            //call theQuit() method on the employee object
            employee.Quit();

            //polymorphism: create an object of type IQuittable and call the Quit() method on it
            IQuittable quittableEmployee = new Employee("Jane", "Doe");
            quittableEmployee.Quit();

            //call SayName() method
            employee.SayName();
        }
    }
}
