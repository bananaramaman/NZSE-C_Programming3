using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using HelloWorld;

namespace HelloWorldTests
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World!";
        [TestMethod]
        public void TestMethod()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                HelloWorld.Program.SayHello();
                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
    [TestClass]
    public class UnitTest2
    {
        private const string Expected = "Goodbye World!";
        [TestMethod]
        public void TestMethod()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                HelloWorld.Program.SayGoodbye();
                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void Test_equal()    //fail
        {   //arrange
            UnitTest program = new UnitTest();
            //act
            double num1 = 2;
            double num2 = 3;
            double expected = 100;
            double results = program.SumofSquareofTwoNumbers(num1, num2);
            //assert
            Assert.AreEqual(expected, results);
        }
        [TestMethod]
        public void Test_equal1()   //pass
        {   //arrange
            UnitTest program = new UnitTest();
            //act
            double num1 = 2;
            double num2 = 3;
            double expected = 13;
            double results = program.SumofSquareofTwoNumbers(num1, num2);
            //assert
            Assert.AreEqual(expected, results);
        }
        [TestMethod]
        public void Test_equal2()   //pass
        {   //arrange
            UnitTest program = new UnitTest();
            //act
            double num1 = -12;
            double num2 = 3.3;
            double expected = 154.89;
            double results = program.SumofSquareofTwoNumbers(num1, num2);
            //assert
            Assert.AreEqual(expected, results);
        }
        [TestMethod]
        public void Test_equal3()   //fail
        {   //arrange
            UnitTest program = new UnitTest();
            //act
            double num1 = 0;
            double num2 = 0;
            double expected = 1;
            double results = program.SumofSquareofTwoNumbers(num1, num2);
            //assert
            Assert.AreEqual(expected, results);
        }
        [TestMethod]
        public void Test_notnull4()   //fail
        {   //arrange
            UnitTest program = new UnitTest();
            //act
            double num1 = 954.78;
            double num2 = 154.2;
            double results = program.SumofSquareofTwoNumbers(num1, num2);
            //assert
            Assert.IsNull(results,"this is not null");
        }
    }
}