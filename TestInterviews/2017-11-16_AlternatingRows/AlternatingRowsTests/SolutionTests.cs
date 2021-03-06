﻿using System;
using System.IO;
using System.Text;
using AlternatingRows;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlternatingRowsTests
{
    [TestClass]
    public class SolutionTests
    {
        #region Naive

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void OutputAlternatingRowsTestNegative()
        {
            OutputAlternatingRowsTest("", -1);
        }

        [TestMethod]
        public void OutputAlternatingRowsTestEmpty()
        {
            OutputAlternatingRowsTest("", 0);
        }

        [TestMethod]
        public void OutputAlternatingRowsTestSingle()
        {
            OutputAlternatingRowsTest("1\r\n", 1);
        }

        [TestMethod]
        public void OutputAlternatingRowsTestDouble()
        {
            OutputAlternatingRowsTest("1*2\r\n3*4\r\n", 2);
        }

        [TestMethod]
        public void OutputAlternatingRowsTestTriple()
        {
            OutputAlternatingRowsTest("1*2*3\r\n7*8*9\r\n4*5*6\r\n", 3);
        }

        [TestMethod]
        public void OutputAlternatingRowsTestFour()
        {
            OutputAlternatingRowsTest("1*2*3*4\r\n9*10*11*12\r\n13*14*15*16\r\n5*6*7*8\r\n", 4);
        }

        [TestMethod]
        public void OutputAlternatingRowsTestFive()
        {
            OutputAlternatingRowsTest("1*2*3*4*5\r\n11*12*13*14*15\r\n21*22*23*24*25\r\n16*17*18*19*20\r\n6*7*8*9*10\r\n", 5);
        }

        [TestMethod]
        public void OutputAlternatingRowsTestSix()
        {
            OutputAlternatingRowsTest("1*2*3*4*5*6\r\n13*14*15*16*17*18\r\n25*26*27*28*29*30\r\n31*32*33*34*35*36\r\n19*20*21*22*23*24\r\n7*8*9*10*11*12\r\n", 6);
        }

        private static void OutputAlternatingRowsTest(string expectedOutput, int n)
        {
            var outputStringBuilder = new StringBuilder();
            using (var textWriter = new StringWriter(outputStringBuilder))
            {
                // arrange
                Console.SetOut(textWriter);

                // act
                Solution.OutputAlternatingRows(n);

                // assert
                Assert.AreEqual(expectedOutput, outputStringBuilder.ToString());
            }
        }

        #endregion

        #region LinkedList of Arrays

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void OutputAlternatingRowsTestArraysLinkedListArraysLinkedListNegative()
        {
            OutputAlternatingRowsTestArraysLinkedList("", -1);
        }

        [TestMethod]
        public void OutputAlternatingRowsTestArraysLinkedListEmpty()
        {
            OutputAlternatingRowsTestArraysLinkedList("", 0);
        }

        [TestMethod]
        public void OutputAlternatingRowsTestArraysLinkedListSingle()
        {
            OutputAlternatingRowsTestArraysLinkedList("1\r\n", 1);
        }

        [TestMethod]
        public void OutputAlternatingRowsTestArraysLinkedListDouble()
        {
            OutputAlternatingRowsTestArraysLinkedList("1*2\r\n3*4\r\n", 2);
        }

        [TestMethod]
        public void OutputAlternatingRowsTestArraysLinkedListTriple()
        {
            OutputAlternatingRowsTestArraysLinkedList("1*2*3\r\n7*8*9\r\n4*5*6\r\n", 3);
        }

        [TestMethod]
        public void OutputAlternatingRowsTestArraysLinkedListFour()
        {
            OutputAlternatingRowsTestArraysLinkedList("1*2*3*4\r\n9*10*11*12\r\n13*14*15*16\r\n5*6*7*8\r\n", 4);
        }

        [TestMethod]
        public void OutputAlternatingRowsTestArraysLinkedListFive()
        {
            OutputAlternatingRowsTestArraysLinkedList("1*2*3*4*5\r\n11*12*13*14*15\r\n21*22*23*24*25\r\n16*17*18*19*20\r\n6*7*8*9*10\r\n", 5);
        }

        [TestMethod]
        public void OutputAlternatingRowsTestArraysLinkedListSix()
        {
            OutputAlternatingRowsTestArraysLinkedList("1*2*3*4*5*6\r\n13*14*15*16*17*18\r\n25*26*27*28*29*30\r\n31*32*33*34*35*36\r\n19*20*21*22*23*24\r\n7*8*9*10*11*12\r\n", 6);
        }

        private static void OutputAlternatingRowsTestArraysLinkedList(string expectedOutput, int n)
        {
            var outputStringBuilder = new StringBuilder();
            using (var textWriter = new StringWriter(outputStringBuilder))
            {
                // arrange
                Console.SetOut(textWriter);

                // act
                Solution.OutputAlternatingRowsArraysLinkedList(n);

                // assert
                Assert.AreEqual(expectedOutput, outputStringBuilder.ToString());
            }
        }

        #endregion

        #region LinkedList of integers

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void OutputAlternatingRowsTestIntegersLinkedListIntegersLinkedListNegative()
        {
            OutputAlternatingRowsTestIntegersLinkedList("", -1);
        }

        [TestMethod]
        public void OutputAlternatingRowsTestIntegersLinkedListEmpty()
        {
            OutputAlternatingRowsTestIntegersLinkedList("", 0);
        }

        [TestMethod]
        public void OutputAlternatingRowsTestIntegersLinkedListSingle()
        {
            OutputAlternatingRowsTestIntegersLinkedList("1\r\n", 1);
        }

        [TestMethod]
        public void OutputAlternatingRowsTestIntegersLinkedListDouble()
        {
            OutputAlternatingRowsTestIntegersLinkedList("1*2\r\n3*4\r\n", 2);
        }

        [TestMethod]
        public void OutputAlternatingRowsTestIntegersLinkedListTriple()
        {
            OutputAlternatingRowsTestIntegersLinkedList("1*2*3\r\n7*8*9\r\n4*5*6\r\n", 3);
        }

        [TestMethod]
        public void OutputAlternatingRowsTestIntegersLinkedListFour()
        {
            OutputAlternatingRowsTestIntegersLinkedList("1*2*3*4\r\n9*10*11*12\r\n13*14*15*16\r\n5*6*7*8\r\n", 4);
        }

        [TestMethod]
        public void OutputAlternatingRowsTestIntegersLinkedListFive()
        {
            OutputAlternatingRowsTestIntegersLinkedList("1*2*3*4*5\r\n11*12*13*14*15\r\n21*22*23*24*25\r\n16*17*18*19*20\r\n6*7*8*9*10\r\n", 5);
        }

        [TestMethod]
        public void OutputAlternatingRowsTestIntegersLinkedListSix()
        {
            OutputAlternatingRowsTestIntegersLinkedList("1*2*3*4*5*6\r\n13*14*15*16*17*18\r\n25*26*27*28*29*30\r\n31*32*33*34*35*36\r\n19*20*21*22*23*24\r\n7*8*9*10*11*12\r\n", 6);
        }

        private static void OutputAlternatingRowsTestIntegersLinkedList(string expectedOutput, int n)
        {
            var outputStringBuilder = new StringBuilder();
            using (var textWriter = new StringWriter(outputStringBuilder))
            {
                // arrange
                Console.SetOut(textWriter);

                // act
                Solution.OutputAlternatingRowsIntegersLinkedList(n);

                // assert
                Assert.AreEqual(expectedOutput, outputStringBuilder.ToString());
            }
        }

        #endregion
    }
}
