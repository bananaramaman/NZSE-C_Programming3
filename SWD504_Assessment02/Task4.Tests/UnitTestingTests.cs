using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task4;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Task4.Tests
{
    [TestClass()]
    public class UnitTestingTests
    {
        [TestMethod]
        public void Test_equal_fail()    //fail
        {   //arrange
            UnitTesting program = new UnitTesting();
            //act
            double num1 = 2;
            double num2 = 3;
            double expected = 100;
            double results = program.SumofSquareofTwoNumbers(num1, num2);
            //assert
            Assert.AreEqual(expected, results);
        }
        [TestMethod]
        public void Test_equal_pass()   //pass
        {   //arrange
            UnitTesting program = new UnitTesting();
            //act
            double num1 = 2;
            double num2 = 3;
            double expected = 13;
            double results = program.SumofSquareofTwoNumbers(num1, num2);
            //assert
            Assert.AreEqual(expected, results);
        }
        [TestMethod]
        public void Test_exception_pass()   //pass
        {   //arrange
            UnitTesting program = new UnitTesting();
            //act
            double num1 = 1522224;
            double num2 = 65656565;
            double results;
            //assert
            Assert.ThrowsException<Exception>(() => results = program.SumofSquareofTwoNumbers(num1, num2));
        }
        [TestMethod]
        public void Test_Instanceof_fail()   //fail
        {   //arrange
            UnitTesting program = new UnitTesting();
            //act
            double num1 = 2;
            double num2 = 3;
            double results = program.SumofSquareofTwoNumbers(num1, num2);
            //assert
            Assert.IsInstanceOfType(results, typeof(Int32));
        }
        [TestMethod]
        public void Test_notnull_fail()   //fail
        {   //arrange
            UnitTesting program = new UnitTesting();
            //act
            double num1 = 954.78;
            double num2 = 154.2;
            double results = program.SumofSquareofTwoNumbers(num1, num2);
            //assert
            Assert.IsNull(results, "this is not null");
        }
    }
}