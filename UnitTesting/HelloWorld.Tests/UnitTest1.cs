using NUnit.Framework;
using System.IO;
using System;

namespace HelloWorld.Tests
{
    public class Tests
    {
        private const string Expected = "Goodbye World!";
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Assert.Pass();
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                HelloWorld.Program.SayGoodbye();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}