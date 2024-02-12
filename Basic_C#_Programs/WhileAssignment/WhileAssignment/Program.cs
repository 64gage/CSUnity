using System;

namespace WhileAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 1 and 100!");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = false;

            do
            {
                switch (number)
                {
                    case 64:
                        Console.WriteLine("You guessed the number 64. That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine(number + " is incorrect. Guess again?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);


            Console.ReadLine();
        }
    }
}
