using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAssignment2
{
    public static class TriangleSolver
    {


        public static string Analyze(int firstNumber, int secondNumber, int thirdNumber)
        {
            string result = string.Empty;

            int tRight, tLeft, tBase;
            tRight = firstNumber + secondNumber;
            tLeft = secondNumber + thirdNumber;
            tBase = thirdNumber + firstNumber;


            if(tRight > thirdNumber && tLeft > 
                firstNumber && tBase > secondNumber) {

                Console.WriteLine("\nThe given numbers forms a Triangle\n");

                if(firstNumber == secondNumber && firstNumber == thirdNumber)
                {
                    result = "The given numbers forms an equilateral Triangle";
                }

                else if ((firstNumber == secondNumber) || (firstNumber == thirdNumber) || (thirdNumber == secondNumber))
                {
                    result = "The given numbers forms an isosceles triangle";
                }
                else if((firstNumber != secondNumber) && (secondNumber != thirdNumber) )
                {
                    result = "The given numbers forms a scalene triangle";
                }

            }
            else
            {
                result = "The given numbers doesn't form a Triangle";
            }

            return result;
        }

    }
}
