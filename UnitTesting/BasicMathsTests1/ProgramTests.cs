using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicMaths;
using System;

namespace BasicAdditionTests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void SumTwoNumbersTest() //Pass
        {
            //Arrange
            Addition Maths = new Addition();  //setting the method to test

            //Act
            int num1 = 25;                  //setting the variables to test
            int num2 = 30;
            int check = Maths.SumTwoNumbers(num1, num2);

            //Assert
            Assert.AreEqual(55, check);     //checking the results
        }
        [TestMethod()]
        public void SumTwoNumbersTest1()    //Pass
        {
            //Arrange
            Addition Maths = new Addition();  //setting the method to test

            //Act
            int num1 = -25;                  //setting the variables to test
            int num2 = 30;
            int check = Maths.SumTwoNumbers(num1, num2);

            //Assert
            Assert.AreEqual(5, check);     //checking the results
        }
        [TestMethod()]
        public void SumTwoNumbersTest2()    //Pass
        {
            //Arrange
            Addition Maths = new Addition();  //setting the method to test

            //Act
            int num1 = 100;                  //setting the variables to test
            int num2 = 30;
            int check = Maths.SumTwoNumbers(num1, num2);

            //Assert
            Assert.AreEqual(130, check);     //checking the results
        }
        [TestMethod()]
        public void SumTwoNumbersTest3()    //Pass
        {
            //Arrange
            Addition Maths = new Addition();  //setting the method to test

            //Act
            int num1 = 1850;                  //setting the variables to test
            int num2 = -2450;
            int check = Maths.SumTwoNumbers(num1, num2);

            //Assert
            Assert.AreEqual(-600, check);     //checking the results
        }
        [TestMethod()]
        public void SumTwoNumbersTest4()    //Pass
        {
            //Arrange
            Addition Maths = new Addition();  //setting the method to test

            //Act
            int num1 = 1;                  //setting the variables to test
            int num2 = 2;
            int check = Maths.SumTwoNumbers(num1, num2);

            //Assert
            Assert.AreEqual(3, check);     //checking the results
        }
        [TestMethod()]
        public void SumTwoNumbersTest5()    //Pass
        {
            //Arrange
            Addition Maths = new Addition();  //setting the method to test

            //Act
            int num1 = -50;                  //setting the variables to test
            int num2 = 50;
            int check = Maths.SumTwoNumbers(num1, num2);

            //Assert
            Assert.AreEqual(0, check);     //checking the results
        }
        [TestMethod()]
        public void SumTwoNumbersTest6()    //Fail
        {
            //Arrange
            Addition Maths = new Addition();  //setting the method to test

            //Act
            int num1 = 25;                  //setting the variables to test
            int num2 = 30;
            int check = Maths.SumTwoNumbers(num1, num2);

            //Assert
            Assert.AreEqual(0, check);     //checking the results
        }
        [TestMethod()]
        public void SumTwoNumbersTest7()    //Fail
        {
            //Arrange
            Addition Maths = new Addition();  //setting the method to test

            //Act
            int num1 = 11;                  //setting the variables to test
            int num2 = 11;
            int check = Maths.SumTwoNumbers(num1, num2);

            //Assert
            Assert.AreEqual(21, check);     //checking the results
        }
    }
}