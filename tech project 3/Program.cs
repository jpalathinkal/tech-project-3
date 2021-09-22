//Programmer: Joshua Palathinkal
//Date: 9/20/21
//Comments: Creating a code to display increments of KMs in Miles
using System;

namespace tech_project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lead Foot Auto Rental Conversion Chart");
            //Ask the user to input a value
            Console.WriteLine("Enter a kilometer integer value between 10 and 25");

            try
            {
                //declaration of variables
                int kilometer, kilometerIncrement;
                double miles;

                //this variable will gather data from the user input
                string input = Console.ReadLine();
                //this variable will be used to perform the iterative statement and is parsed as an integer
                kilometerIncrement = int.Parse(input);

                //initialization of kilometer variable
                kilometer = 0;

                //if the input of kilometers is between 10 and 25 execute a Do While loop
                if ((kilometerIncrement >= 10) && (kilometerIncrement <= 25))
                {
                    Console.WriteLine("The kilometer increment value given was " + kilometerIncrement.ToString());
                    Console.WriteLine("Kilometer        Miles");

                    do
                    {
                        //kilometer to miles conversion and displaying
                        miles = kilometer * 0.621371;
                        Console.WriteLine(kilometer + "                " + miles);
                        //setting the increment value
                        kilometer = kilometer + kilometerIncrement;
                    } while (kilometer <= 200); //end of DoWhile loop
                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey(true);
                }//end of if
            }//end of try
            catch
            {
                Console.WriteLine("Please make sure the value you entered is an integer value between 10 and 25");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);
            }//end of catch
                }
            }

        }
