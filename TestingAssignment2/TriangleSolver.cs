using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAssignment2
{
    public static class TriangleSolver
    {
        /*This method takes integer parameters and returns string. 
        It takes integer parameters to analyze whether the Trinagle can be formed or not. 
       If a Triangle can be formed then which type of Triangle i.e. scalene, isosceles, orequilateral. */
        public static string Analyze(int firstNumber, int secondNumber, int thirdNumber)
        {
            //Assigned empty to result variable, if not while returning it returns unassigned value
            string result = string.Empty;
            //Writing a simple math for the Triangle sides
            int tRight, tLeft, tBase;           
            tRight = firstNumber + secondNumber;
            tLeft = secondNumber + thirdNumber;
            tBase = thirdNumber + firstNumber;

            //Checking if a triangle can be formed with condition
            if (tRight > thirdNumber && tLeft > firstNumber && tBase > secondNumber)
            {
                Console.WriteLine("The given numbers form a Triangle");

                //Checking if all the sides are equal
                if(firstNumber == secondNumber && firstNumber == thirdNumber)
                {
                    result = "The numbers (" + firstNumber+ ", " + secondNumber + ", "
                                +thirdNumber +") can form an equilateral Triangle";
                }

                // checking at least two sides are equal
                else if ((firstNumber == secondNumber) || (firstNumber == thirdNumber) || (thirdNumber == secondNumber))
                {
                    result = "The numbers (" + firstNumber+ ", " + secondNumber + ", " 
                                        + thirdNumber +") can form an isosceles triangle";
                }
                //checking if none of the sides are equal
                else if((firstNumber != secondNumber) && (secondNumber != thirdNumber) )
                {
                    result = "The numbers (" + firstNumber + ", " +secondNumber + ", " + 
                                            thirdNumber +") can form a scalene triangle";
                }

            }
            else
            {
                result = "The given numbers (" + firstNumber + ", " +secondNumber + ", " + 
                                thirdNumber + ")  doesn't form a Triangle";
            }
            
            //returning the string variable result
            return result ;
        }

    }
}
