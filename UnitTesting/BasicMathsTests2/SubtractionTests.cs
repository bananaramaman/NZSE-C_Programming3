using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicMaths;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicSubtractionTests
{
    [TestClass()]
    public class SubtractionTests
    {
        [TestMethod()]
        public void Subtraction_Exception_Test() //Pass
        {
            //Arrange
            Subtraction Maths = new Subtraction();  //setting the method to test

            //Act
            int num1 = 25;                  //setting the variables to test
            int num2 = 30;

            //Assert
            Assert.ThrowsException<Exception>(()=>Maths.SumTwoNumbers(num1,num2));     //checking the results
        }
        [TestMethod()]
        public void Subtraction_ExceptionUnhandled_Test() //Fail
        {
            //Arrange
            Subtraction Maths = new Subtraction();  //setting the method to test

            //Act
            int num1 = 30;                  //setting the variables to test
            int num2 = 30;

            //Assert
            Assert.ThrowsException<Exception>(() => Maths.SumTwoNumbers(num1, num2));     //checking the results
        }
        [TestMethod()]
        public void Subtraction_AreEqual_Test() //Pass
        {
            //Arrange
            Subtraction Maths = new Subtraction();  //setting the method to test

            //Act
            int num1 = 30;                  //setting the variables to test
            int num2 = 30;
            int check = Maths.SumTwoNumbers(num1, num2);
            int expected = 0;
            //Assert
            Assert.AreEqual(check, expected);   //checking the results
        }
        [TestMethod()]
        public void Subtraction_NotEqual_Test() //Fail
        {
            //Arrange
            Subtraction Maths = new Subtraction();  //setting the method to test

            //Act
            int num1 = 31;                  //setting the variables to test
            int num2 = 30;
            int check = Maths.SumTwoNumbers(num1, num2);
            int expected = 0;
            //Assert
            Assert.AreEqual(check, expected);   //checking the results

        }
        [TestMethod()]
        public void Subtraction_nullResult_Test() //Fail
        {
            //Arrange
            Subtraction Maths = new Subtraction();  //setting the method to test

            //Act
            int num1 = 5;                  //setting the variables to test
            int num2 = 30;
            int check = Maths.SumTwoNumbers(num1, num2);
            int expected = -25;
            //Assert
            Assert.AreEqual(check, expected);
            Assert.ThrowsException<Exception>(() => Maths.SumTwoNumbers(num1, num2));     //checking the results
        }
        [TestMethod()]
        public void Subtraction_Result_Test() //Pass
        {
            //Arrange
            Subtraction Maths = new Subtraction();  //setting the method to test

            //Act
            int num1 = 29;                  //setting the variables to test
            int num2 = 30;
            //Assert                        //checking the results
            Assert.ThrowsException<Exception>(() => Maths.SumTwoNumbers(num1, num2));
        }
    }
            
}