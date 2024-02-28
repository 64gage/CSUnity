using System;


namespace DateTime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("Current date and time: " + currentDateTime);
            Console.Write("Enter a number of hours: ");

            int hours = Convert.ToInt32(Console.ReadLine());
            DateTime futureDateTime = currentDateTime.AddHours(hours);

            Console.WriteLine($"In {hours} hours, it will be: {futureDateTime}");
        }
    }
}
