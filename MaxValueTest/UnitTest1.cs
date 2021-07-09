using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FindMaximumGenerics;


namespace MaxValueTest
{
    [TestClass]
    public class UnitTest1
    {
        FindMaxInt findMaxInt;

        public UnitTest1()
        {
            findMaxInt = new FindMaxInt();
        }

        [TestMethod]
        public void TestMethod1()
        {
            int first = 80;
            int second = 56;
            int third = 21;
            int actual = findMaxInt.FindMax(first, second, third);
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
            int actual = findMaxInt.FindMax(first, second, third);
            int expected = second;
            expected.CompareTo(actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int first = 80;
            int second = 56;
            int third = 100;
            int actual = findMaxInt.FindMax(first, second, third);
            int expected = third;
            expected.CompareTo(actual);
        }
    }
}
