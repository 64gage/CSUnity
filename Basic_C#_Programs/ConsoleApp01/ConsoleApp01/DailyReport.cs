using System;

namespace ConsoleApp01
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Srudent Daily Report");
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Name: " + yourName);

            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("Course: " + yourCourse);

            Console.WriteLine("What page number?");
            string pageNum = Console.ReadLine();
            int pageNumber = Convert.ToInt32(pageNum);
            Console.WriteLine("Page Number: " + pageNumber);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            string needsHelp = Console.ReadLine();
            bool needsHelp1 = Convert.ToBoolean(needsHelp);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string yourExperience = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string yourFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string amountStudied = Console.ReadLine();
            int hoursStudied = Convert.ToInt32(amountStudied);
            Console.WriteLine("Hours Studied: " + hoursStudied);

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();


        }
    }
}
