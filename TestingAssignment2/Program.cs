using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAssignment2
{
    class Program
    {
       
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

                Console.WriteLine("Please choose the options below:\n");
                Console.WriteLine("1.Enter triangle dimensions");
                Console.WriteLine("2.Exit\n");

                string input = Console.ReadLine();

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
         
               bool selectedOption = !int.TryParse(input, out int choice);

                int firstNumber, SecondNumber, thirdNumber;

                switch (choice)
                {

                    case 1:

                        do
                        {
                            Console.Write("\nPlease enter the first Integer:");
                            input = Console.ReadLine();
                        }
                        while (

                        !int.TryParse(input, out firstNumber)
                        
                        );

                        do
                        {
                            Console.Write("\nPlease enter the second Integer:");
                            input = Console.ReadLine();
                        } while (!int.TryParse(input, out SecondNumber));

                        do
                        {
                            Console.Write("\nPlease enter the third Integer:");
                            input = Console.ReadLine();
                        } while (!int.TryParse(input, out thirdNumber));

                        Console.WriteLine(TriangleSolver.Analyze(firstNumber, SecondNumber, thirdNumber) +
                                             "\n--------------------------------------------------");
                        break;

                    case 2:
                        Environment.Exit(0);
                        break;
                }


            }

        }
    }
}
