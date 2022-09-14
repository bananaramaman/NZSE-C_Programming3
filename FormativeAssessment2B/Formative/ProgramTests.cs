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
        [TestMethod()]
        public void Second_Test_Pass()    //Pass test
        {   //Arrange
            Dividend test = new Dividend();
            //Act
            int dividend = 50;
            int divisor = 8;
            int check = test.Testing(dividend, divisor);
            //int expected = 2;
            //Assert
            Assert.IsInstanceOfType(check, typeof(Int32));
        }
        [TestMethod()]
        public void Second_Test_Fail()    //fail test
        {   //Arrange
            Dividend test = new Dividend();
            //Act
            int dividend = 50;
            int divisor = 5;
            int check = test.Testing(dividend, divisor);
            //int expected = 2;
            //Assert
            Assert.IsInstanceOfType(check, typeof(String));
        }
        [TestMethod()]
        public void Third_Test_Pass()    //Pass test
        {   //Arrange
            Dividend test = new Dividend();
            //Act
            int dividend = 50;
            int divisor = 0;
            int check;
            //Assert
            Assert.ThrowsException<DivideByZeroException>(() => check = test.Testing(dividend, divisor),"Exception Thrown");   
        }
        [TestMethod()]
        public void Third_Test_Fail()    //fail test
        {   //Arrange
            Dividend test = new Dividend();
            //Act
            int dividend = 50;
            int divisor = 5;
            int check;
            //Assert
            Assert.ThrowsException<DivideByZeroException>(() => check = test.Testing(dividend, divisor));
        }
        [TestMethod()]
        public void Fourth_Test_Pass()    //Pass test
        {   //Arrange
            Dividend test = new Dividend();
            //Act
            int dividend = -50;
            int divisor = -5;
            int check;
            //Assert
            Assert.ThrowsException<Exception>(() => check = test.Testing(dividend, divisor));
        }
        [TestMethod()]
        public void Fourth_Test_Fail()    //Fail test
        {   //Arrange
            Dividend test = new Dividend();
            //Act
            int dividend = 50;
            int divisor = 8;
            int check;
            //Assert
            Assert.ThrowsException<Exception>(() => check = test.Testing(dividend, divisor));
        }
    }
}