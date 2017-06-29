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
        }
    }
}
