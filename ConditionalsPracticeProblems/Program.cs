using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsPracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            //set values for problem
            double firstNumber;
            double secondNumber;
            //let user know what to expect with app
            //have user enter required data
            Console.WriteLine("Please type two numbers to determine if they are the same.");
            Console.WriteLine("Enter your first number ");
            firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number ");
            secondNumber = double.Parse(Console.ReadLine());

            //write formula to calculate answer or solve problem and print answer for user
            if (firstNumber == secondNumber)
            {
                Console.WriteLine("The numbers " + firstNumber + " and " + secondNumber + " are the same number");
            }
            else
            {
                Console.WriteLine("The numbers " + firstNumber + " and " + secondNumber + " are not equal to each other");
            }

            //Problem 2
            //set values for variable
            int userNumber;

            //ask user to enter a whole number
            Console.WriteLine("Please enter a whole number here: ");
            userNumber = int.Parse(Console.ReadLine());

            //write calculation to determine if number is divisible by 2
            if (userNumber % 2 == 0)
            {
                Console.WriteLine(+userNumber + "is an even number");
            }
            else
            {
                Console.WriteLine(+userNumber + " is an odd number");
            }

            //Problem 3
            //set variable
            int usrNumber;
            //ask user to input number
            Console.WriteLine("Please type a number here: ");
            usrNumber = int.Parse(Console.ReadLine());
            //determine if number is positive being greater than zero or negative by being less than zero and print answer
            if (usrNumber > 0)
            {
                Console.WriteLine("The value " + usrNumber + " is a positive number");
            }
            else if (usrNumber < 0)
            {
                Console.WriteLine("The value " + usrNumber + " is a negative number");
            }
            else if (usrNumber == 0)
            {
                Console.WriteLine("O is neither positive or negative but is considered to be non-negative.");
            }

        }

    }
}
