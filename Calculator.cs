using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continue_calc = true;
            while (continue_calc == true)
            {


                Console.WriteLine("Welcome to the calculator program\n");

                // Ask the user for two number and store them as floats
                Console.WriteLine("Enter the first number: ");
                float number1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number: ");
                float number2 = float.Parse(Console.ReadLine());

                // Output the menu options
                Console.WriteLine("\nEnter the menu number of the calculation to perform: ");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Multiplication");
                Console.WriteLine("4 - Division\n");

                // Ask for the menu option
                string menuOption = Console.ReadLine();

                // Perform a subroutine based on the menu option
                if (menuOption == "1")
                {
                    Addition(number1, number2);
                }
                else if (menuOption == "2")
                {
                    Subtraction(number1, number2);
                }
                else if (menuOption == "3")
                {
                    Multiply(number1, number2);
                }
                else if (menuOption == "4")
                {
                    Division(number1, number2);
                }
                else
                {
                    Console.WriteLine("Please choose a valid option");
                }
                Console.Write("Do you want to continue, yes (1) or no (2): ");
                string continue_input = Console.ReadLine();

                if (continue_input == "2")
                {
                    continue_calc = false;
                }
                else { };

            }
        }

        // The addition procedure has two floats as parameters, adds them together and outputs the result
        static void Addition(float num1, float num2)
        {
            Console.WriteLine("\nThe result is: " + (num1 + num2));
        }
        static void Subtraction(float num1, float num2)
        {
            Console.WriteLine("\nThe result is: " + (num1 - num2));
        }
        static void Division(float num1, float num2)
        {
            Console.WriteLine("\nThe result is: " + (num1 / num2));
        }
        static void Multiply(float num1, float num2)
        {
            Console.WriteLine("\nThe result is: " + (num1 * num2));
        }
    }
}

