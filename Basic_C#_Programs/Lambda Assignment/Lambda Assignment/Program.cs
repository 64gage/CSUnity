using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_Assignment
{
    class Program
    {
        class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Id { get; set; }
        }
        static void Main(string[] args)
        {

            //Create list of employees
            List<Employee> employees = new List<Employee>
            {
                new Employee { FirstName = "Joe", LastName = "Shmoe", Id = 1},
                new Employee { FirstName = "Alice", LastName = "Smith", Id = 2},
                new Employee { FirstName = "Joe", LastName = "Davis", Id = 3},
                new Employee { FirstName = "Justin", LastName = "Brown", Id = 4},
                new Employee { FirstName = "Jacob", LastName = "Bar", Id = 5},
                new Employee { FirstName = "Luke", LastName = "Bell", Id = 6},
                new Employee { FirstName = "Joe", LastName = "King", Id = 7},
                new Employee { FirstName = "Haley", LastName = "Bee", Id = 8},
                new Employee { FirstName = "Rob", LastName = "Smooth", Id = 9},
                new Employee { FirstName = "Alan", LastName = "Walker", Id = 10}
            };

            //using foreach loop to create a list of the joes
            List<Employee> joes = new List<Employee>();
            foreach (var employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joes.Add(employee);
                }
            }

            //Using Lambda expression to create a list of all employees named joe
            List<Employee> joesLambda = employees.Where(x => x.FirstName == "Joe").ToList();

            //use lambda to list employees with Id greater than 5
            List<Employee> greaterThan5Lambda = employees.Where(x => x.Id > 5).ToList();

            //Displaying results
            Console.WriteLine("Employees with the first name 'Joe':");
            foreach (var joe in joes)
            {
                Console.WriteLine($"{joe.FirstName} {joe.LastName}, ID: {joe.Id}");
            }

            Console.WriteLine("\nEmployees with the first name 'Joe' (using lambda):");
            foreach (var joe in joesLambda)
            {
                Console.WriteLine($"{joe.FirstName} {joe.LastName}, ID: {joe.Id}");
            }

            Console.WriteLine("\nEmployees woth an Id number greater than 5 (using lambda):");
            foreach (var emp in greaterThan5Lambda)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}, ID: {emp.Id}");
            }
        }
    }
}
