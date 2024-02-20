using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = new string[] { "Blue", "Red", "Yellow" };
            Console.WriteLine("Select your favorite primary color.");
            Console.WriteLine("Blue: \"0\"");
            Console.WriteLine("Red: \"1\"");
            Console.WriteLine("Yellow: \"2\"");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput > 2)
            {
                Console.WriteLine("The index you selected does not exist.");
                
            }
            else
            {
                Console.WriteLine("You chose:");
                Console.WriteLine(stringArray[userInput]);
            }

            int[] numArray = new int[] { 16, 32, 64 };
            Console.WriteLine("Select your favorite number.");
            Console.WriteLine("16: \"0\"");
            Console.WriteLine("32: \"1\"");
            Console.WriteLine("64: \"2\"");
            int numInput = Convert.ToInt32(Console.ReadLine());

            if (numInput > 2)
            {
                Console.WriteLine("The index you selected does not exist.");
                Console.ReadLine();
            }
            else { 
                Console.WriteLine("You chose:");
                Console.WriteLine(numArray[numInput]);
                Console.ReadLine();
            }

            List<string> stringList = new List<string>();
            stringList.Add("Zero");
            stringList.Add("One");
            stringList.Add("Two");
            stringList.Add("Three");
            Console.WriteLine("Select a number.");
            Console.WriteLine("Zero: \"0\"");
            Console.WriteLine("One: \"1\"");
            Console.WriteLine("Two: \"2\"");
            Console.WriteLine("Three: \"3\"");
            int stringInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You chose:");
            Console.WriteLine(stringList[stringInput]);
            Console.ReadLine();

            //List<int> intList = new List<int>();
            //intList.Add(4);
            //intList.Add(10);
            //Console.WriteLine(intList[0]);
            //Console.ReadLine();
            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

            //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

            //numArray2[5] = 650;


            //Console.WriteLine(numArray2[5]);
            //Console.ReadLine();

        }
    }
}
