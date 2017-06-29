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
            ////6.28.2017 - Problem 1
            ////set values for problem
            //double firstNumber;
            //double secondNumber;
            ////let user know what to expect with app
            ////have user enter required data
            //Console.WriteLine("Please type two numbers to determine if they are the same.");
            //Console.WriteLine("Enter your first number ");
            //firstNumber = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your second number ");
            //secondNumber = double.Parse(Console.ReadLine());

            ////write formula to calculate answer or solve problem and print answer for user
            //if (firstNumber == secondNumber)
            //{
            //    Console.WriteLine("The numbers " + firstNumber + " and " + secondNumber + " are the same number");
            //}
            //else
            //{
            //    Console.WriteLine("The numbers " + firstNumber + " and " + secondNumber + " are not equal to each other");
            //}

            ////6.28.2017 - Problem 2
            ////set values for variable
            //int userNumber;

            ////ask user to enter a whole number
            //Console.WriteLine("Please enter a whole number here: ");
            //userNumber = int.Parse(Console.ReadLine());

            ////write calculation to determine if number is divisible by 2
            //if (userNumber % 2 == 0)
            //{
            //    Console.WriteLine(+userNumber + "is an even number");
            //}
            //else
            //{
            //    Console.WriteLine(+userNumber + " is an odd number");
            //}

            ////6.28.2017 - Problem 3
            ////set variable
            //int usrNumber;
            ////ask user to input number
            //Console.WriteLine("Please type a number here: ");
            //usrNumber = int.Parse(Console.ReadLine());
            ////determine if number is positive being greater than zero or negative by being less than zero and print answer
            //if (usrNumber > 0)
            //{
            //    Console.WriteLine("The value " + usrNumber + " is a positive number");
            //}
            //else if (usrNumber < 0)
            //{
            //    Console.WriteLine("The value " + usrNumber + " is a negative number");
            //}
            //else if (usrNumber == 0)
            //{
            //    Console.WriteLine("O is neither positive or negative but is considered to be non-negative.");
            //}


            ////6.28.2017 - Problem 4
            ////get user input for problem
            //Console.WriteLine("Type a letter to check if it is a vowel or consonant");
            ////set case statements to print answer based on user input
            ////prepare error message to print if user does not provide correct data type
            //string letter = Console.ReadLine();
            //switch (letter)
            //{
            //    case "a":
            //        Console.WriteLine("The letter a is a vowel");
            //        break;
            //    case "b":
            //        Console.WriteLine("The letter b is a consonant");
            //        break;
            //    case "c":
            //        Console.WriteLine("The letter c is a consonant");
            //        break;
            //    case "d":
            //        Console.WriteLine("The letter d is a consonant");
            //        break;
            //    case "e":
            //        Console.WriteLine("The letter e is a vowel");
            //        break;
            //    case "f":
            //        Console.WriteLine("The letter f is a consonant");
            //        break;
            //    case "g":
            //        Console.WriteLine("The letter g is a consonant");
            //        break;
            //    case "h":
            //        Console.WriteLine("The letter h is a consonant");
            //        break;
            //    case "i":
            //        Console.WriteLine("The letter i is a vowel");
            //        break;
            //    case "j":
            //        Console.WriteLine("The letter j is a consonant");
            //        break;
            //    case "k":
            //        Console.WriteLine("The letter k is a consonant");
            //        break;
            //    case "l":
            //        Console.WriteLine("The letter l is a consonant");
            //        break;
            //    case "m":
            //        Console.WriteLine("The letter m is a consonant");
            //        break;
            //    case "n":
            //        Console.WriteLine("The letter n is a consonant");
            //        break;
            //    case "o":
            //        Console.WriteLine("The letter o is a vowel");
            //        break;
            //    case "p":
            //        Console.WriteLine("The letter p is a consonant");
            //        break;
            //    case "q":
            //        Console.WriteLine("The letter q is a vowel");
            //        break;
            //    case "r":
            //        Console.WriteLine("The letter r is a consonant");
            //        break;
            //    case "s":
            //        Console.WriteLine("The letter s is a consonant");
            //        break;
            //    case "t":
            //        Console.WriteLine("The letter t is a consonant");
            //        break;
            //    case "u":
            //        Console.WriteLine("The letter u is a vowel");
            //        break;
            //    case "v":
            //        Console.WriteLine("The letter v is a consonant");
            //        break;
            //    case "w":
            //        Console.WriteLine("The letter w is a consonant");
            //        break;
            //    case "x":
            //        Console.WriteLine("The letter x is a consonant");
            //        break;
            //    case "y":
            //        Console.WriteLine("The letter y is a consonant");
            //        break;
            //    case "z":
            //        Console.WriteLine("The letter z is a consonant");
            //        break;
            //    default:
            //        Console.WriteLine("Error: you did not enter an appropriate letter. Please try again.");
            //        break;
            //}

            ////6.28.2017 - Problem 5
            ////set the values for the problem
            //double numberOne;
            //double numberTwo;
            ////tell user what to expect
            ////have user enter required data           
            //Console.WriteLine("Please enter two numbers to find out which number has the greatest value.");
            //Console.WriteLine("Enter your first number ");
            //numberOne = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your second number ");
            //numberTwo = int.Parse(Console.ReadLine());
            ////solve problem using calculation and print answer
            //if (numberOne > numberTwo)
            //{
            //    Console.WriteLine(+numberOne + " is the bigger number");
            //}
            //else
            //{
            //    Console.WriteLine(+numberTwo + " is the bigger number");
            //}

            ////6.28.2017 - Problem 6
            ////set the values for the problem
            //double frstNumber;
            //double scondNumber;
            //double thirdNumber;
            //double fourthNumber;

            ////tell user what to expect
            ////have user enter required data           
            //Console.WriteLine("Please enter four numbers to find out the mean for those numbers.");
            //Console.WriteLine("Enter your first number ");
            //frstNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your second number ");
            //scondNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your third number ");
            //thirdNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your fourth number ");
            //fourthNumber = int.Parse(Console.ReadLine());

            ////solve problem using calculation and print answer
            ////this is messy and needs to be rewritten in a simpler manner
            //Console.WriteLine("The mean for the numbers you entered is " + ((frstNumber + scondNumber + thirdNumber + fourthNumber) / 4));

            //6.29.2017 - FIZZ BUZZ
            // int testNum;
            // //numOne is Fizz
            // int numOne;
            // //numTwo is Buzz
            // int numTwo;
            // //let user know what to expect with app
            // //welcome user and have user enter first number
            // Console.WriteLine("To play Fizz Buzz, please type two numbers between 1 and 9.");
            // Console.WriteLine("Enter your first number: ");

            // numOne = int.Parse(Console.ReadLine());
            // if (numOne >= 1 && numOne <= 9)
            // {
            //     Console.WriteLine("Your number is valid, continue on!");
            // }
            // else
            // {
            //     Console.WriteLine( + numOne + " is not a number between 0 and 9. Please try again!");
            //     return;
            // }
            // //have user enter first number
            // Console.WriteLine("Enter your second number: ");
            // numTwo = int.Parse(Console.ReadLine());
            // if (numTwo >= 1 && numTwo <= 9)
            // {
            //     Console.WriteLine("Your number is valid, continue on!");
            // }
            // else
            // {
            //     Console.WriteLine( + numTwo + " is not a number between 0 and 9. Please try again!");
            //     return;
            // }

            // Console.WriteLine("Now enter a test number: ");
            // testNum = int.Parse(Console.ReadLine());

            // //write formula to determine Fizz Buzz outcomes
            // if (testNum % numOne == 0 && testNum % numTwo != 0)
            // {
            //     Console.WriteLine("Fizz!");
            // }
            // else if (testNum % numTwo == 0 && testNum % numOne != 0)
            // {
            //     Console.WriteLine("Buzz!");
            // }
            // else if (testNum % numOne == 0 && testNum % numTwo == 0)
            // {
            //     Console.WriteLine("FizzBuzz!");
            // }
            //else
            // {
            //     Console.WriteLine( + testNum + " is not a multiple of either number you selected.");
            // }

            //6.29.2017 - Extra Problem 1
            //Write a console application to get a number from the user and print whether it is positive or negative.

            //set variable
            int userNumber;
            //ask user to input number
            Console.WriteLine("Please type a number here: ");
            userNumber = int.Parse(Console.ReadLine());
            //determine if number is positive being greater than zero or negative by being less than zero and print answer
            if (userNumber > 0)
            {
                Console.WriteLine("The value " + userNumber + " is a positive number");
            }
            else
            {
                Console.WriteLine("The value " + userNumber + " is a negative number");
            }

            
            //6.29.2017 - Extra Problem 2
            //Write a console application to ask the user for a number; 
            //if it is not zero, then it will ask for a second number and display their product; otherwise, it will display "0". 

            //set the variables for the problem
            //double userNumber1;
            //double userNumber2;
            ////ask the user to type two numbers
            //Console.WriteLine("Please enter two numbers you want to multiply.");
            //Console.WriteLine("Please enter your first number: ");
            //userNumber1 = int.Parse(Console.ReadLine());

            ////create calculation to solve problem and print answer for user
            //if (userNumber1 != 0)
            //{
            //    Console.WriteLine("Please enter your second number: ");
            //    userNumber2 = int.Parse(Console.ReadLine());
            //    Console.WriteLine(userNumber1 * userNumber2);
            //}
            //else
            //{
            //    Console.WriteLine("0");
            //}


            //6.29.2017 - Extra Problem 3
            //Write a console application to ask the user for two numbers, 
            //and show their division if the second number is not zero; otherwise, it will print "I cannot divide"

            ////set the values for the problem
            //double numberOne;
            //double numberTwo;
            ////tell user what to expect
            ////have user enter required data           
            //Console.WriteLine("Please enter two numbers you want to divide.");
            //Console.WriteLine("Enter your first number ");
            //numberOne = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your second number ");
            //numberTwo = int.Parse(Console.ReadLine());

            ////solve problem using calculation and print answer
            //if (numberTwo <= 0 || numberTwo >= 0)
            //{
            //    Console.WriteLine(+numberOne + " divided by " + numberTwo + " = " + (numberOne / numberTwo));
            //}
            //else
            //{
            //    Console.WriteLine("I cannot divide");
            //}


            //6.29.2017 - Extra Problem 4
            //Write a console application to get three numbers from the user and print the greatest one.

            ////set the values for the problem
            //double numberOne;
            //double numberTwo;
            //double numberThree;
            ////tell user what to expect
            ////have user enter required data           
            //Console.WriteLine("Please enter three numbers to find out which number has the greatest value.");
            //Console.WriteLine("Enter your first number ");
            //numberOne = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your second number ");
            //numberTwo = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your third number ");
            //numberThree = int.Parse(Console.ReadLine());

            ////solve problem using calculation and print answer
            //if (numberOne > numberTwo && numberOne > numberThree)
            //{
            //    Console.WriteLine(+numberOne + " has the greatest value");
            //}
            //else if (numberTwo > numberOne && numberTwo > numberThree)
            //{
            //    Console.WriteLine(+numberTwo + " has the greatest value");
            //}
            //else
            //{
            //    Console.WriteLine(+numberThree + " has the greatest value");
            //}
        }

    }
}

