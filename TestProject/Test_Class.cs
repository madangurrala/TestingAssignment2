using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingAssignment2;
using NUnit.Framework;

namespace TestProject
{
    [TestFixture]
    public class Test_Class
    {

        //This method tests if given input forms an isosceles triangle
        [Test]
        public void Test_isosceles()
        {
            //Arrange
            int firstNum = 12;
            int secondNum = 34;
            int thirdNum = 34;

            //Act
            string result = TriangleSolver.Analyze(firstNum, secondNum, thirdNum);

            //Assert
            Assert.AreEqual(result, "The given numbers forms an isosceles triangle");
        }

        //This method tests if given input forms an equilateral triangle
        [Test]
        public void Test_Equilateral()
        {
            //Arrange
            int firstNum = 12;
            int secondNum = 12;
            int thirdNum = 12;

            //Act
            string result = TriangleSolver.Analyze(firstNum, secondNum, thirdNum);

            //Assert
            Assert.AreEqual(result, "The given numbers forms an equilateral Triangle");
        }

        //This method tests if given input forms a scalene triangle
        [Test]
        public void Test_scalene()
        {
            //Arrange
            int firstNum = 132;
            int secondNum = 145;
            int thirdNum = 167;

            //Act
            string result = TriangleSolver.Analyze(firstNum, secondNum, thirdNum);

            //Assert
            Assert.AreEqual(result, "The given numbers forms a scalene triangle");
        }


        //This method tests where the sum of the two inputs is greater than the third one
        [Test]
        public void Two_Inputs_Sum_IsGreater_ThanThirdOne()
        {
            //Arrange
            int firstNum = 40;
            int secondNum = 30;
            int thirdNum = 100;

            //Act
            string result = TriangleSolver.Analyze(firstNum, secondNum, thirdNum);

            //Assert
            Assert.AreEqual(result, "The given numbers doesn't form a Triangle");
        }

        //This method tests when all the zeros are passed
        [Test]
        public void All_The_Zero_Inputs()
        {
            //Arrange
            int firstNum = 0;
            int secondNum = 0;
            int thirdNum = 0;

            //Act
            string result = TriangleSolver.Analyze(firstNum, secondNum, thirdNum);

            //Assert
            Assert.AreEqual(result, "The given numbers doesn't form a Triangle");
        }

        //This method tests when negative values are passed
        [Test]
        public void One_Negative_Value()
        {
            //Arrange
            int firstNum = -100;
            int secondNum = 90;
            int thirdNum = 15;

            //Act
            string result = TriangleSolver.Analyze(firstNum, secondNum, thirdNum);

            //Assert
            Assert.AreEqual(result, "The given numbers doesn't form a Triangle");
        }


        //[Test]
        //public void Tests_First_If_Condition4()
        //{
        //    //Arrange
        //    int firstNum = 120;
        //    int secondNum = 345;
        //    int thirdNum = 109;

        //    //Act
        //    string result = TriangleSolver.Analyze(firstNum, secondNum, thirdNum);

        //    //Assert
        //    Assert.AreEqual(result, "The given numbers doesn't form a Triangle");
        //}

        //[Test]
        //public void Tests_First_If_Condition5()
        //{
        //    //Arrange
        //    int firstNum = 0;
        //    int secondNum = 0;
        //    int thirdNum = 0;

        //    //Act
        //    string result = TriangleSolver.Analyze(firstNum, secondNum, thirdNum);

        //    //Assert
        //    Assert.AreEqual(result, "The given numbers doesn't form a Triangle");
        //}

       
    }
}
