using RegularExpressionMatching;
using MinimumTimeToCollectAllApplesInATree;
using MediumOfTwoSortedArrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DivideTwoIntegers;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinimumTimeToCollectAllApplesInATree.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void MinTimeTest()
        {
            var s = new Solution();
            var edges = new int[][] { new int[]{ 0, 1 }, new int[]{ 0, 2 }, new int[]{ 1, 4 }, new int[] { 1, 5 }, new int[] { 2, 3 }, new int[] { 2, 6 } };
            var time = s.MinTime(7, edges, new bool[] { false, false, true, false, true, true, false});
            Assert.AreEqual(8, time);
        }
    }
}

namespace MediumOfTwoSortedArrays.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void FindMedianSortedArraysTest()
        {
            var s = new Solution();
            Assert.AreEqual(2, s.FindMedianSortedArrays(new int[] { 1, 3 }, new int[] {2}));
        }
    }
}

namespace DivideTwoIntegers.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void DivideTest()
        {
            var s = new Solution();            
            Assert.AreEqual(3, s.Divide(10, 3));
            Assert.AreEqual(-3, s.Divide(-10, 3));
            Assert.AreEqual(2147483647, s.Divide(2147483647, 1));
            Assert.AreEqual(2147483647, s.Divide(-2147483648, -1));
        }
    }
}