using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestWCF.RedPillSVC;

namespace TestWCF
{
    [TestClass]
    public class ReadifyTest
    {
        [TestMethod]
        public void TestTringleEquilateral()
        {
            RedPillClient RP = new RedPillClient();
            TriangleType trnglType = RP.WhatShapeIsThis(10, 10, 10);
            Assert.AreEqual(TriangleType.Equilateral, trnglType, string.Format("{0}", trnglType));
        }

        [TestMethod]
        public void TestTringleIsosceles()
        {
            RedPillClient RP = new RedPillClient();
            TriangleType trnglType = RP.WhatShapeIsThis(10, 10, 100);
            Assert.AreEqual(TriangleType.Isosceles, trnglType);
        }

        [TestMethod]
        public void TestTringleScalene()
        {
            RedPillClient RP = new RedPillClient();
            TriangleType trnglType = RP.WhatShapeIsThis(38, 35, 100);
            Assert.AreEqual(TriangleType.Scalene, trnglType);
        }

        [TestMethod]
        public void TestTringleSError()
        {
            RedPillClient RP = new RedPillClient();
            TriangleType trnglType = RP.WhatShapeIsThis(10, 0, 22);
            Assert.AreEqual(TriangleType.Error, trnglType);
        }

        [TestMethod]
        public void TestReverseWords()
        {
            RedPillClient RP = new RedPillClient();
            string revLorem = RP.ReverseWords("Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.");
            Assert.Inconclusive(revLorem);
        }

        [TestMethod]
        public void TestReverseWordsNull()
        {
            RedPillClient RP = new RedPillClient();
            string revLorem = RP.ReverseWords(null);
            Assert.Inconclusive(revLorem);
        }
        
        [TestMethod]
        public void TestFibonacciNumber10000()
        {
            RedPillClient RP = new RedPillClient();
            long i = 10000;
            long result = RP.FibonacciNumber(i);
            Assert.Inconclusive(string.Format("input number {0}, output number {1}", i , result));
        }

                [TestMethod]
        public void TestFibonacciNumber100()
        {
            RedPillClient RP = new RedPillClient();
            long i = 100;
            long result = RP.FibonacciNumber(i);
            Assert.Inconclusive(string.Format("input number {0}, output number {1}", i , result));
        }
    }
}
