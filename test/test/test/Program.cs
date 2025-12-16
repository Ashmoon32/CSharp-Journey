using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;

namespace test.calculator
{
    class program
    {
        static void Main(string[] args)
        {

            double num1, num2, result;
            bool isChoice = true;
            Console.WriteLine("Welcome to the Calculator!");
            do
            {
                Console.WriteLine("Select an operation you want to perform from 1 - 5.(Default is Addition!)");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.Write("Your choice: ");
                string choice = Console.ReadLine();


                if(choice == "5")
                {
                    Console.WriteLine("Bye! Have a nice day...");
                    isChoice = false;
                }
                else
                {
                    Console.Write("Enter first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    switch (choice)
                    {
                        case "1":
                            result = num1 + num2;
                            Console.WriteLine($"{num1} + {num2} = {result}");
                            break;
                        case "2":
                            result = num1 - num2;
                            Console.WriteLine($"{num1} - {num2} = {result}");
                            break;
                        case "3":
                            result = num1 * num2;
                            Console.WriteLine($"{num1} * {num2} = {result}");
                            break;
                        case "4":
                            result = num1 / num2;
                            if(num2 == 0)
                            {
                                Console.WriteLine("Invalid input! Cannot divided by zero!");
                            }
                            else
                            {
                                Console.WriteLine($"{num1} / {num2} = {result}");
                            }
                                break;
                        case "5":
                            Console.WriteLine("Bye! Have a nice day...");
                            isChoice = false;
                            break;

                        default:
                            result = num1 + num2;
                            Console.WriteLine($"{num1} + {num2} = {result}");
                            break;
                    }
                    Console.WriteLine("===========================================================");
                }                                  
            } while (isChoice == true);
        }
    }
}

