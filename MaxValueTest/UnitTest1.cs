using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FindMaximumGenerics;


namespace MaxValueTest
{
   
        [TestClass]
        public class UnitTest1
        {

            [TestMethod]
            public void TestMethod1()
            {

                int[] array = { 10, 5, 100, 85, 96, 2, 1 };
                int actual = new FindMaximum<int>(array).MaxMethod();
                int expected = 100;
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void TestMethodFloat1()
            {
                double[] array = { 1.1, 1.3, 5.6, 5.36, 6.2, 80.5, 1 };
                double actual = new FindMaximum<double>(array).MaxMethod();
                double expected = 80.5;
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void TestMethodString3()
            {
                char[] first = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
                char actual = new FindMaximum<char>(first).MaxMethod();
                char expected = 'G';
                Assert.AreEqual(expected, actual);
            }

        }
    }

