using System;
using System.Collections.Generic;

namespace Parameters_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate employee object with type "string" as the generic parameter
            Employee<string> stringEmployee = new Employee<string>();
            stringEmployee.Things = new List<string> { "Apple", "Bannana", "Orange" };

            //instantiate an employee object with type "int: as the generic parameter
            Employee<int> intEmployee = new Employee<int>();
            intEmployee.Things = new List<int> { 1, 2, 3, 4, 5 };

            //print all of the Things to the console
            Console.WriteLine("String Employee Things:");
            foreach (var item in stringEmployee.Things)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nInteger Employee Things:");
            foreach (var item in intEmployee.Things)
            {
                Console.WriteLine(item);
            }
        }
    }
}
