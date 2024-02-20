using System;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();

            //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    if (names[j] == "Jesse")
            //    {
            //        Console.WriteLine(names[j]);
            //    }
            //}
            //Console.ReadLine();

            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //}
            //Console.ReadLine();

            //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

            //foreach (string name in names)
            //{
            //    if (name == "Jesse")
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
            //Console.ReadLine();

            //List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
            //List<int> passingScores = new List<int>();

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        passingScores.Add(score);
            //    }
            //}

            //Console.WriteLine(passingScores.Count);
            //Console.ReadLine();


            string[] titleNames = { "Wings of ", "Prince of ", "Harbinger of " };

            Console.WriteLine("Please enter a proper noun: ");
            string userTitle = Console.ReadLine();

            Console.WriteLine("Possible Titles:");

            for (int i = 0; i < titleNames.Length; ++i)
            {
                titleNames[i] = titleNames[i] + userTitle;
                Console.WriteLine(titleNames[i]);
            }
            

            //infinite loop fixed
            // also loops that uses "<"
            for (int count = 0; count < 20; ++count)
            {
                Console.WriteLine(count);
                
            }
            Console.WriteLine("Please Press \"Enter\" to continue.");
            Console.ReadLine();


            //loop that uses "<="
            for (int count1 = 0; count1 <= 20; ++count1)
            {
                Console.WriteLine(count1);

            }
            Console.WriteLine("Please Press \"Enter\" to continue.");
            Console.ReadLine();

            //unique list of strings
            List<string> colorName = new List<string>() { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet", "red", "orange", "yellow", "green", "blue", "indigo", "violet" };

            Console.WriteLine("Input a color to see if it's in the list");
            string userColor = Console.ReadLine();
            

            foreach (string color in colorName)
            {
                if (color == userColor)
                {
                    Console.WriteLine("Your color is at index " + colorName.IndexOf(userColor));
                    break;
                }
                else if (color == "violet" && color != userColor)
                {
                    Console.WriteLine("The list does not contain your color.");
                }
            }
            Console.WriteLine("Please Press \"Enter\" to continue.");
            Console.ReadLine();

            List<string> letterGrade = new List<string>() { "a", "a", "b", "c", "a", "c" };
            

            Console.WriteLine("Type a letter grade (a, b, or c) to find out where it is in the list. ");
            string userLetter = Console.ReadLine();
            int count2 = 0;
            for (int i = 0; i < letterGrade.Count; ++i)
            {
                if (letterGrade[i] == userLetter)
                {
                    Console.WriteLine(i);
                    count2++;
                }
                else if (letterGrade[i] != userLetter && i == 5 && count2 == 0)
                {
                    Console.WriteLine("The text you entered is not in the list.");
                }
            }
            Console.WriteLine("Please Press \"Enter\" to continue.");
            Console.ReadLine();

            List<string> wordList = new List<string>() { "Red", "Yellow", "Blue", "Red" };
            List<string> wordReserve = new List<string>() { "o", "o", "o", "o" };
            
            foreach (string word in wordList)
            {
                int count4 = 0;

                for (int i = 0; i < wordList.Count; i++)
                {
                    
                    
                    if (word == wordList[i] && count4 > 0)
                    {
                        wordReserve[i] = (" yes");
                    }
                    else if (word == wordList[i] && count4 == 0 && wordReserve[i] != " yes")
                    {
                        wordReserve[i] = (" no");
                        count4++;
                    }
                    else if (word != wordList[i] && wordReserve[i] != " yes")
                    {
                        wordReserve[i] = (" no");
                    }
                    
                }

            }
            for (int j = 0; j < wordList.Count; j++)
            {
                Console.WriteLine(wordList[j] + wordReserve[j]);
            }

            
            

        }
    }
}
