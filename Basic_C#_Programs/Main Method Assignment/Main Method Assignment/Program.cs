using System;

namespace Main_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOps = new MathOperations();

            mathOps.PerformOperation(5, 10);

            mathOps.PerformOperation(num1: 8, num2: 20);
        }
    }
}
