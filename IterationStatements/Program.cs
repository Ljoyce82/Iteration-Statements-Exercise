using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Transactions;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void ThousandLoop()
        {
            Console.WriteLine("Printing from 1000 to -1000! Press Enter");
            Console.ReadLine();
            for (int i = 1000; i >= -1000; --i)
            {
                Console.WriteLine(i);
            }
        }


        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void NineLoop()
        {
            Console.WriteLine("Count to 999 by 3, Press Enter");
            Console.ReadLine();
            for (int i = 0; i < 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }


        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static bool EqualsMe()
        {
            while (!false) 
            {
                Console.WriteLine("Please enter two numbers with spaces to compare for equality: ");

                string input = Console.ReadLine();
                string[] numbers = input.Split(' ');

                if (numbers.Length != 2)
                {
                    Console.WriteLine("Please enter two numbers with space between. ");
                    continue;// trying make so user cant purposflly crash prog
                }

                if (int.TryParse(numbers[0], out int a) && int.TryParse(numbers[1], out int b))
                {
                    return a == b;
                }
                else
                {
                    Console.WriteLine("Please enter number only. ");


                }
              continue;
            }
         }

        //Write a method to check whether a given number is even or odd
        public static bool OddOrEven()
        {
           
            Console.WriteLine("Enter your number to check for odd or even: ");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                return number % 2 == 0 ? true : false;
            }
            else
            {
                Console.WriteLine("That is not a number please try again");
                return false;
            }
        }


        //Write a method to check whether a given number is positive or negative
        public static string PosOrNeg()
        {
            Console.WriteLine("Enter a number to check for positive or negative: ");
            string numStr = Console.ReadLine();

            if (int.TryParse(numStr, out int num))
            { 

                if (num > 0)
                {
                    return "Positive";
                }
                else if (num < 0)
                {
                    return "Negative";
                }
                else
                {
                    return "Zero";
                }
            }
            else
            {
                return "That is not a valid number.";
            }
           
        }


        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static bool CanVote()
        {
            while (true)
            {
                Console.WriteLine("Enter your age to see if you can vote");
                string ageInput = Console.ReadLine();




                if (int.TryParse(ageInput, out int age))
                {
                    if (age >= 18)
                    {
                        Console.WriteLine("You can Vote");
                        return true;
                    }

                    else
                    {
                        Console.WriteLine("Your not old enough to Vote sorry!");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("That is not real age please enter your age");
                    continue;
                }
            }
        }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static bool YourNum()
        {
            int num;
            bool isValid = false;

            while (!isValid)
            {
                Console.WriteLine("Enter a number between 10 and -10: ");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out num))
                {
                    if (num >= -10 && num <= 10)
                    {
                        isValid = true;
                        Console.WriteLine("Your number falls in the correct range. ");
                    }
                    else
                    {
                        Console.WriteLine("Not correct please enter a number form -10 to 10");
                    }
                }

                else
                {
                    Console.WriteLine("That is not a number please try agian. ");
                }
            }
            return true;
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplyTable()
        {
            Console.WriteLine("Enter number to multiply: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int number))
            {
                Console.WriteLine($"Your {number} multiplied from 1-12");

                for (int i = 1; i <= 12; i++)
                {
                    int result = number * i;
                    Console.WriteLine($"{number} * {i} = {result}");
                }
            }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
            
        }   

              


        //Call the methods to test them in the Main method below
        // All the programs work running them all same time might break the hamsters!
        static void Main()
        {

            ThousandLoop();
           // Console.ReadLine();

            NineLoop();
           // Console.ReadLine();

            bool isEqual = EqualsMe();
            Console.WriteLine(isEqual ? "The numbers are equal" : "The numbers are not equal. ");

            bool isEven = OddOrEven();
            Console.WriteLine(isEven ? "The number is even. " : "The number is odd. ");

            string userNum = PosOrNeg();
            Console.WriteLine(userNum);

            CanVote();

            YourNum();

            MultiplyTable();


           




        }
    }
        
    
}
