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


            //Problem 4
            //get user input for problem
            Console.WriteLine("Type a letter to check if it is a vowel or consonant");
            //set case statements to print answer based on user input
            //prepare error message to print if user does not provide correct data type
            string letter = Console.ReadLine();
            switch (letter)
            {
                case "a":
                    Console.WriteLine("The letter a is a vowel");
                    break;
                case "b":
                    Console.WriteLine("The letter b is a consonant");
                    break;
                case "c":
                    Console.WriteLine("The letter c is a consonant");
                    break;
                case "d":
                    Console.WriteLine("The letter d is a consonant");
                    break;
                case "e":
                    Console.WriteLine("The letter e is a vowel");
                    break;
                case "f":
                    Console.WriteLine("The letter f is a consonant");
                    break;
                case "g":
                    Console.WriteLine("The letter g is a consonant");
                    break;
                case "h":
                    Console.WriteLine("The letter h is a consonant");
                    break;
                case "i":
                    Console.WriteLine("The letter i is a vowel");
                    break;
                case "j":
                    Console.WriteLine("The letter j is a consonant");
                    break;
                case "k":
                    Console.WriteLine("The letter k is a consonant");
                    break;
                case "l":
                    Console.WriteLine("The letter l is a consonant");
                    break;
                case "m":
                    Console.WriteLine("The letter m is a consonant");
                    break;
                case "n":
                    Console.WriteLine("The letter n is a consonant");
                    break;
                case "o":
                    Console.WriteLine("The letter o is a vowel");
                    break;
                case "p":
                    Console.WriteLine("The letter p is a consonant");
                    break;
                case "q":
                    Console.WriteLine("The letter q is a vowel");
                    break;
                case "r":
                    Console.WriteLine("The letter r is a consonant");
                    break;
                case "s":
                    Console.WriteLine("The letter s is a consonant");
                    break;
                case "t":
                    Console.WriteLine("The letter t is a consonant");
                    break;
                case "u":
                    Console.WriteLine("The letter u is a vowel");
                    break;
                case "v":
                    Console.WriteLine("The letter v is a consonant");
                    break;
                case "w":
                    Console.WriteLine("The letter w is a consonant");
                    break;
                case "x":
                    Console.WriteLine("The letter x is a consonant");
                    break;
                case "y":
                    Console.WriteLine("The letter y is a consonant");
                    break;
                case "z":
                    Console.WriteLine("The letter z is a consonant");
                    break;
                default:
                    Console.WriteLine("Error: you did not enter an appropriate letter. Please try again.");
                    break;
            }
        }

    }
}
