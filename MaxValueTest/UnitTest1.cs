using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FindMaximumGenerics;


namespace MaxValueTest
{
    [TestClass]
    public class UnitTest1
    {
        FindMaximum findMax;

        public UnitTest1()
        {
            findMax = new FindMaximum();
        }

        [TestMethod]
        public void TestMethod1()
        {
            int first = 80;
            int second = 56;
            int third = 21;
            int actual = findMax.FindMaxInt(first, second, third);
            int expected = first;
            // expected.CompareTo(actual);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int first = 70;
            int second = 90;
            int third = 21;
            int actual = findMax.FindMaxInt(first, second, third);
            int expected = second;
            expected.CompareTo(actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int first = 80;
            int second = 56;
            int third = 100;
            int actual = findMax.FindMaxInt(first, second, third);
            int expected = third;
            expected.CompareTo(actual);
        }
        [TestMethod]
        public void TestMethodFloat1()
        {
            double first = 11.3;
            double second = 5.6;
            double third = 2.1;
            double actual = findMax.FindMax(first, second, third);
            double expected = first;
            expected.CompareTo(actual);
        }
        [TestMethod]
        public void TestMethodFloat2()
        {
            double first = 8.0;
            double second = 53.6;
            double third = 2.1;
            double actual = findMax.FindMax(first, second, third);
            double expected = first;
            expected.CompareTo(actual);
        }
        [TestMethod]
        public void TestMethodFloat3()
        {
            double first = 8.0;
            double second = 5.6;
            double third = 12.1;
            double actual = findMax.FindMax(first, second, third);
            double expected = first;
            expected.CompareTo(actual);
        }
        [TestMethod]
        public void TestMethodString1()
        {
            string first = "Hello";
            string second = "Hi";
            string third = "Welcome";
            string actual = findMax.FindMax(first, second, third);
            string expected = first;
            expected.CompareTo(actual);
        }
        [TestMethod]
        public void TestMethodString2()
        {
            string first = "Hi";
            string second = "Hello";
            string third = "Welcome";
            string actual = findMax.FindMax(first, second, third);
            string expected = first;
            expected.CompareTo(actual);
        }
        [TestMethod]
        public void TestMethodString3()
        {
            string first = "Welcome";
            string second = "Hi";
            string third = "Hello";
            string actual = findMax.FindMax(first, second, third);
            string expected = first;
            expected.CompareTo(actual);
        }
    }
}
