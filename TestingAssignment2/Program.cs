using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAssignment2
{
    class Program
    {
        public static int firstNumber, secondNumber, thirdNumber;
        public static string input;
       
        static void Main(string[] args)
        {
            //Creating object of the program class
            Program testing = new Program();

            // calling the TrinalgeMenu method which is in the testing object
            testing.TriangleMenu();

            Console.ReadKey();
           
        }

        //This method shows up the menu options and does all the work that this program require
        public void TriangleMenu()
        {
            //creating a bool variable to keep showing the menu to us based on the condition
            bool menuOptions = true;

            while (menuOptions == true)
            {
                //Writing menu to the console
                Console.WriteLine("Please choose the options below:\n");
                Console.WriteLine("1.Enter triangle dimensions");
                Console.WriteLine("2.Exit\n");

                //taking the input entered by customer
                input = Console.ReadLine();

                //if customer doesn't select the correct option this statement gets executed
                if (input != "1" &
                    input != "2")
                {
                    Console.WriteLine("\nOops!! You have selected and incorrect Option. Please enter either " +
                       "Number 1 or 2 on keyboard.\n");
                }
                else
                {
                    menuOptions = true;
                }
               
               //checking customer has entered a valid number
               bool selectedOption = !int.TryParse(input, out int choice);

                //Using  switch case to execute the functionality of selected options
                switch (choice)
                {

                    //This case calls three methods which takes the input and validates them
                    case 1:

                        FirstIntegerValidation();
                        SecondIntegerValidation();
                        ThirdIntegerValidation();
                    //Writing to console and also calling the Analyze method to analyze the given numbers
                        Console.WriteLine(TriangleSolver.Analyze(firstNumber, secondNumber, thirdNumber) +
                            "\n---------------------------------------------------\n");                      
                        break;
                    //Wehn option 2 is selected in the menu programs quits
                    case 2:
                        Environment.Exit(0);
                        break;
                }


            }

        }

        /*This method takes the input from customer, validates, reports if the input is not an Integer 
        and returns firstnumber*/
        public int FirstIntegerValidation()
        {
            Console.Write("\nPlease enter the first Integer:");
           string input = Console.ReadLine();

            if (!int.TryParse(input, out firstNumber))
            {
                Console.WriteLine("\nPlease enter a valid Integer");

                FirstIntegerValidation();
            }

            return firstNumber;
        }

        /*This method takes the input from customer, validates, reports if the input is not an Integer 
       and returns secondnumber*/
        public int SecondIntegerValidation()
        {
            Console.Write("\nPlease enter the second Integer:");
            input = Console.ReadLine();

            if (!int.TryParse(input, out secondNumber))
            {
                Console.WriteLine("\nPlease enter a valid Integer");

                SecondIntegerValidation();
            }

            return secondNumber;
        }

        /*This method takes the input from customer, validates, reports if the input is not an Integer 
      and returns thirdnumber*/
        public int ThirdIntegerValidation()
        {
            Console.Write("\nPlease enter the third Integer:");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out thirdNumber))
            {
                Console.WriteLine("\nPlease enter a valid Integer");

                ThirdIntegerValidation();
            }

            return thirdNumber;
        }


    }
}
