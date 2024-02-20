using System;
using System.Collections.Generic;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numList = new List<int>() { 8, 32, 64, 96, 112 };
                for (int i = 0; i < numList.Count; i++)
                {
                    Console.WriteLine(numList[i]);
                }
                Console.WriteLine("Pick a number to divide the list by.");
                int divInput = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numList.Count; i++)
                {
                    int total = numList[i] / divInput;
                    Console.WriteLine(total);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by zero.");
                return;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number.");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            


        }
    }
}
