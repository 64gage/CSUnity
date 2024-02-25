using System;

namespace Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate MathOperations Class
            MathOperations mathOps = new MathOperations();

            // get user input
            Console.WriteLine("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            //call method
            mathOps.DivideByTwo(userInput);

            //call methos with output parameters
            mathOps.DivideByTwoWithOutput(userInput, out int output);
            Console.WriteLine($"Using method with output parameters: {output}");

            //Call overloaded method
            mathOps.DivideByTwo(10.0);

            //Call static method
            StaticMathOperations.MultiplyByTwo(userInput);
        }
    }
}
