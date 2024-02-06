using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate1 = Console.ReadLine();
            float hRate1 = Convert.ToSingle(hourlyRate1);
            Console.WriteLine("Hours worked per week?");
            string hoursPerWeek1 = Console.ReadLine();
            float hPWeek1 = Convert.ToSingle(hoursPerWeek1);
            float total1 = hRate1 * hPWeek1 * 52;

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate2 = Console.ReadLine();
            float hRate2 = Convert.ToSingle(hourlyRate2);
            Console.WriteLine("Hours worked per week?");
            string hoursPerWeek2 = Console.ReadLine();
            float hPWeek2 = Convert.ToSingle(hoursPerWeek2);
            float total2 = hRate2 * hPWeek2 * 52;

            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(total1);
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(total2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueFalse;
            if (total1 > total2)
            {
                trueFalse = true;
            }
            else
            {
                trueFalse = false;
            }
            string trueFalseString = Convert.ToString(trueFalse);
            Console.WriteLine(trueFalseString);
            Console.ReadLine();
        }
    }
}
