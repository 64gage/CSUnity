using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Assignment
{
    public class MathOperations
    {
        public void DivideByTwo(int number)
        {
            int result = number / 2;

            Console.WriteLine($"Dividing {number} by 2 results in: {result}");
        }

        public void DivideByTwoWithOutput(int number, out int result)
        {
            result = number / 2;
        }

        //Ovberload
        public void DivideByTwo(double number)
        {
            double result = number / 2;
            Console.WriteLine($"Dividing {number} by 2 results in: {result}");
        }

        
    }
}
