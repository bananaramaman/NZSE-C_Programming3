using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicMaths;
using System;


namespace BasicMathsTests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void SumTwoNumbersTest()
        {
            //Arrange
            Program Maths = new Program();  //setting the method to test

            //Act
            int num1 = 25;                  //setting the variables to test
            int num2 = 30;
            int check = Maths.SumTwoNumbers(num1, num2);

            //Assert
            Assert.AreEqual(55, check);     //checking the results
        }
    }
}
