using System;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please state the weight of the package.");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else { }

            Console.WriteLine("Package Width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Package height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Package length");
            int length = Convert.ToInt32(Console.ReadLine());

            int size = (width * height * length);
            int dimensionTotal = (width + height + length);

            if (dimensionTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express");
            }

            double quote = (size * weight) / 100;

            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));

            Console.ReadLine();
        }
    }
}
