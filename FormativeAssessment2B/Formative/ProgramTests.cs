using Microsoft.VisualStudio.TestTools.UnitTesting;
using FA2B_Task2;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace FA2B_Task2Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void First_Test_Pass()    //pass
        {   //Arrange
            Dividend test = new Dividend();
            //Act
            int dividend = 50;
            int divisor = 8;
            int check = test.Testing(dividend,divisor);
            int expected = 2;
            //Assert
            Assert.AreEqual(check, expected);
        }
        [TestMethod()]
        public void First_Test_Fail()    //fail test
        {   //Arrange
            Dividend test = new Dividend();
            //Act
            int dividend = 45;
            int divisor = 4;
            int check = test.Testing(dividend, divisor);
            int expected = 2;
            //Assert
            Assert.AreEqual(check, expected);
        }
    }
}