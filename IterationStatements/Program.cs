using System.Runtime.InteropServices;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void ThousandLoop()
        {
            for (int i = 1000; i >= -1000; --i)
            {
                Console.WriteLine(i);
            }
        }


        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void NineLoop()
        {
            for (int i = 0; i < 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }


        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static bool EqualsMe()
        {
            int a = 5;
            int b = 13;
            var isEqual = a == b; return isEqual;
        }

        //Write a method to check whether a given number is even or odd
        public static bool OddOrEven()
        {
            int number = 14;
            return number % 2 == 0 ? true : false;

        }


        //Write a method to check whether a given number is positive or negative
        public static string PosOrNeg()
        {
            int num = -18;

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


        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static bool CanVote()
        {
            string ageInput = "20";
            if (int.TryParse(ageInput, out int age))
            {
                return age >= 18;
            }
            else
            {
                return false;
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
                Console.WriteLine("Enter a number: ");
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
            public static void MultiplyTable(int number)
            {
            Console.WriteLine($"Multipilcation table for {number}");
             for (int i = 1; i <= 12; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }
        }
              


        //Call the methods to test them in the Main method below
        // All the programs work running them all same time might break the hamsters!
        static void Main()
        {

            ThousandLoop();

            NineLoop();

            bool result = Program.EqualsMe();
            Console.WriteLine(result);

            bool isEven = OddOrEven();
            Console.WriteLine(isEven);

            string total = Program.PosOrNeg();
            Console.WriteLine(result);

            bool howOld = Program.CanVote();
            Console.WriteLine(howOld);

            YourNum();

            Program.MultiplyTable(5);




        }
    }
        
    
}
