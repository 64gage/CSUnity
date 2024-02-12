using System;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main()
        {
            //Getting information from user
            Console.WriteLine("What is your age?");
            string userAgeString = Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI? (Answer true or false)");
            string hasDUIString = Console.ReadLine();

            Console.WriteLine("How many speeding tickets have you had?");
            string speedingTicketString = Console.ReadLine();
            //Getting information from user END

            //Converting information into proper datatype
            int userAge = Convert.ToInt32(userAgeString);

            bool hasDUI = Convert.ToBoolean(hasDUIString);

            int speedingTickets = Convert.ToInt32(speedingTicketString);
            //Converting information END

            //Checking for insurance requirements
            bool result = (userAge > 15 && (hasDUI == false) && speedingTickets <= 3);
            //Checking for requirements END

            //Printing Results
            Console.WriteLine("Qualified?");
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
