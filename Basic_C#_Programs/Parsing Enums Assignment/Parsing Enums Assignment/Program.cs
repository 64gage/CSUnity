using System;

namespace Parsing_Enums_Assignment
{
    class Program
    {
        enum DayOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter the current day of the week: ");
                string userInput = Console.ReadLine();
                DayOfWeek currentDay;

                //Attempt to parse the user input into DayOfWeek enum
                if (Enum.TryParse(userInput, out currentDay))
                {
                    Console.WriteLine($"You entered: {currentDay}");
                }
                else
                {
                    throw new ArgumentException("Invalid day of the week.");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Please enter an actual day of the week.");
            }
        }
    }
}
