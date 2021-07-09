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

            int first = 80;
            int second = 56;
            int third = 21;
            int actual = FindMaximum<int>.FindMax(first, second, third);
            int expected = first;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int first = 70;
            int second = 90;
            int third = 21;
            int actual = FindMaximum<int>.FindMax(first, second, third);
            int expected = second;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int first = 80;
            int second = 56;
            int third = 100;
            int actual = FindMaximum<int>.FindMax(first, second, third);
            int expected = third;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodFloat1()
        {
            double first = 11.3;
            double second = 5.6;
            double third = 2.1;
            double actual = FindMaximum<double>.FindMax(first, second, third);
            double expected = first;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodFloat2()
        {
            double first = 8.0;
            double second = 53.6;
            double third = 2.1;
            double actual = FindMaximum<double>.FindMax(first, second, third);
            double expected = second;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodFloat3()
        {
            double first = 8.0;
            double second = 5.6;
            double third = 12.1;
            double actual = FindMaximum<double>.FindMax(first, second, third);
            double expected = third;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodString1()
        {
            string first = "Apple";
            string second = "Banana";
            string third = "Peach";
            string actual = FindMaximum<string>.FindMax(first, second, third);
            string expected = second;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodString2()
        {
            string first = "Peach";
            string second = "Apple";
            string third = "Banana";
            string actual = FindMaximum<string>.FindMax(first, second, third);
            string expected = first;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodString3()
        {
            string first = "Banana";
            string second = "Peach";
            string third = "Apple";
            string actual = FindMaximum<string>.FindMax(first, second, third);
            string expected = second;
            Assert.AreEqual(expected, actual);
        }

    }
}
