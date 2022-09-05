using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicMaths;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace PrimeNumberTests
{
    [TestClass()]
    public class PrimeNumbersTests
    {
        [TestMethod()]
        public void Prime_Equal_Test()     //Pass
        {   //Arrange
            PrimeNumbers program = new PrimeNumbers();
            //Act
            int y = 10;
            int[] check = program.Prime(y);
            int[] expected = { 7, 5, 3, 2 };
            //Assert
            CollectionAssert.AreEqual(check, expected);
        }
        [TestMethod()]
        public void Prime_Equal1_Test()     //Pass
        {   //Arrange
            PrimeNumbers program = new PrimeNumbers();
            //Act
            int y = 13;     //value of y changed
            int[] check = program.Prime(y);
            int[] expected = { 7, 5, 3, 2 };
            //Assert
            CollectionAssert.AreEqual(check, expected);
        }
        [TestMethod()]
        public void Prime_nEqual_Test()     //Fail
        {   //Arrange
            PrimeNumbers program = new PrimeNumbers();
            //Act
            int y = 21;     //value of y changed
            int[] check = program.Prime(y);
            int[] expected = {13, 7, 5, 3, 2 };
            //Assert
            CollectionAssert.AreEqual(check, expected);
        }
        [TestMethod()]
        public void Prime_nEqual1_Test()     //Pass
        {   //Arrange
            PrimeNumbers program = new PrimeNumbers();
            //Act
            int y = 21;     //value of y changed
            int[] check = program.Prime(y);
            int[] expected = { 8, 5, 3, 2 };
            //Assert
            CollectionAssert.AreEqual(check, expected);
        }
        [TestMethod()]
        public void Prime_Fail_Test()     //Fail
        {   //Arrange
            PrimeNumbers program = new PrimeNumbers();
            //Act
            int y = 10;     //value of y changed
            int[] check = program.Prime(y);
            int[] expected = { 7, 5, 3, 2 };
            //Assert
            if (check[0] == 7)
            {
                Assert.Fail("test has failed");
            }
            return;
        }
        [TestMethod()]
        public void Prime_Pass_Test()     //Pass
        {   //Arrange
            PrimeNumbers program = new PrimeNumbers();
            //Act
            int y = 10;     //value of y changed
            int[] check = program.Prime(y);
            int[] expected = { 7, 5, 3, 2 };
            //Assert
            if (check[0] != 7)
            {
                Assert.Fail("test has failed");
            }
            return;
        }
        [TestMethod()]
        public void Prime_Type_Test()     //Pass
        {   //Arrange
            PrimeNumbers program = new PrimeNumbers();
            //Act
            int y = 10;     //value of y changed
            int[] check = program.Prime(y);
            int[] expected = { 7, 5, 3, 2 };
            //Assert
            if (check[0] == 7)
            {
                CollectionAssert.AllItemsAreInstancesOfType(check, typeof(int),"test has passed");
            }
            return;
        }
        [TestMethod()]
        public void Prime_Type1_Test()     //Fail
        {   //Arrange
            PrimeNumbers program = new PrimeNumbers();
            //Act
            int y = 10;     //value of y changed
            int[] check = program.Prime(y);
            int[] expected = { 7, 5, 3, 2 };
            //Assert
            if (check[0] == 7)
            {
                CollectionAssert.AllItemsAreInstancesOfType(check, typeof(char),"this is not the type you are looking for");
            }
            return;
        }
    }
}