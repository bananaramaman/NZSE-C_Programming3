using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicMaths;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace EvenNumberTests
{
    [TestClass()]
    public class EvenNumbersTests
    {
        [TestMethod()]
        public void EvenTest_AreEqual()     //Pass
        {
            EvenNumbers program = new EvenNumbers();

            int[]y = new int [11];
            int[]x = new int [6];
            int[]check = program.Even(y,x);
            int[]expected = {0,2,4,6,8,10};

            CollectionAssert.AreEqual(check, expected);
        }
        [TestMethod()]
        public void EvenTest_NotEqual()     //fail
        {
            EvenNumbers program = new EvenNumbers();

            int[] y = new int[10];
            int[] x = new int[5];
            int[] check = program.Even(y, x);
            int[] expected = { 0, 2, 4, 6, 8, 10};

            CollectionAssert.AreEqual(check, expected);
        }
        [TestMethod()]
        public void EvenTest_NotNull()      //Pass
        {
            EvenNumbers program = new EvenNumbers();

            int[] y = new int[10];
            int[] x = new int[5];
            int[] check = program.Even(y, x);

            CollectionAssert.AllItemsAreNotNull(check); 
        }
        [TestMethod()]
        public void EvenTest_EqualType1()         //fail
        {
            EvenNumbers program = new EvenNumbers();

            int[] y = new int[10];
            int[] x = new int[5];
            int[] check = program.Even(y, x);

            CollectionAssert.AllItemsAreInstancesOfType(check, typeof(int[]));
        }
        [TestMethod()]
        public void EvenTest_EqualType2()      //fail
        {
            EvenNumbers program = new EvenNumbers();

            int[] y = new int[10];
            int[] x = new int[5];
            int[] check = program.Even(y, x);

            CollectionAssert.AllItemsAreInstancesOfType(check, typeof(Array));
        }
        [TestMethod()]
        public void EvenTest_EqualType3()      //Pass
        {
            EvenNumbers program = new EvenNumbers();

            int[] y = new int[10];
            int[] x = new int[5];
            int[] check = program.Even(y, x);

            CollectionAssert.AllItemsAreInstancesOfType(check, typeof(int));
        }
        [TestMethod()]
        public void EvenTest_Contains()      //Pass
        {
            EvenNumbers program = new EvenNumbers();

            int[] y = new int[10];
            int[] x = new int[5];
            int[] check = program.Even(y, x);

            CollectionAssert.Contains(x, x[4]%2);
        }
        [TestMethod()]
        public void EvenTest_Contains1()      //fail
        {
            EvenNumbers program = new EvenNumbers();

            int[] y = new int[10];
            int[] x = new int[5];
            int[] check = program.Even(y, x);

            CollectionAssert.Contains(x, x[1]!/2);
        }
    }   
}