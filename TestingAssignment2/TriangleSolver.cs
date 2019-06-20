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

            int tRight, tLeft, tBase;

            //Writing a simple math for the Triangle sides
            tRight = firstNumber + secondNumber;
            tLeft = secondNumber + thirdNumber;
            tBase = thirdNumber + firstNumber;

            //Checking if a triangle can be formed with condition
            if(tRight > thirdNumber && tLeft > firstNumber && tBase > secondNumber)
            {
                if(firstNumber == secondNumber && firstNumber == thirdNumber)
                {
                    result = "The given numbers form a Triangle and it is an equilateral Triangle";
                }

                else if ((firstNumber == secondNumber) || (firstNumber == thirdNumber) || (thirdNumber == secondNumber))
                {
                    result = "The given numbers form a Triangle and it is an isosceles triangle";
                }
                else if((firstNumber != secondNumber) && (secondNumber != thirdNumber) )
                {
                    result = "The given numbers form a Triangle and it is a scalene triangle";
                }

            }
            else
            {
                result = "The given numbers doesn't form a Triangle";
            }

            //Returning result which is a string variable
            return result;
        }

    }
}
