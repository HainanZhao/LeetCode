using PermutationInString;
using OnstructBinarSearchTreeFromPreorderTraversal;
using Triangle;
using HIndex;
using RectaguleArea;
using GenerateParentheses;
using PowerN;
using TrappingRainWater;
using MinimumTimeToCollectAllApplesInATree;
using MediumOfTwoSortedArrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DivideTwoIntegers;
using System;
using System.Collections.Generic;
using System.Text;

namespace PermutationInString.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void CheckInclusionTest()
        {
            var s = new Solution();
            var valid = s.CheckInclusion("ab", "dcefgbajilkx");
            Assert.AreEqual(true, valid);
        }
    }
}

namespace OnstructBinarSearchTreeFromPreorderTraversal.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void BstFromPreorderTest()
        {
            var s = new Solution();
            var root = s.BstFromPreorder(new int[] { 8, 5, 1, 7, 10, 12 });
            Assert.AreEqual(root.val, 8);
        }
    }
}

namespace Triangle.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void MinimumTotalTest()
        {
            var s = new Solution();
            var list = new List<IList<int>>();
            list.Add(new List<int>() { 2 });
            list.Add(new List<int>() { 3, 4 });
            list.Add(new List<int>() { 6, 5, 7 });
            list.Add(new List<int>() { 4, 1, 8, 3 });

            Assert.AreEqual(11, s.MinimumTotal(list));
        }
    }
}

namespace HIndex.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void HIndexTest()
        {
            var s = new Solution();
            Assert.AreEqual(3, s.HIndex(new int[] { 3, 0, 6, 1, 5 }));
            Assert.AreEqual(1, s.HIndex(new int[] {1}));
            Assert.AreEqual(0, s.HIndex(new int[] { 0 }));
        }
    }
}

namespace RectaguleArea.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void ComputeAreaTest()
        {
            var s = new Solution();
            Assert.AreEqual(45, s.ComputeArea(-3, 0, 3, 4, 0, -1, 9, 2));
            Assert.AreEqual(20, s.ComputeArea(-2,-2, 2, 2, -1, 4, 1, 6));
        }
    }
}

namespace GenerateParentheses.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void GenerateParenthesisTest()
        {
            var s = new Solution();
            Assert.AreEqual(1, s.GenerateParenthesis(1).Count);
            Assert.AreEqual(2, s.GenerateParenthesis(2).Count);
            Assert.AreEqual(5, s.GenerateParenthesis(3).Count);
        }
    }
}

namespace PowerN.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void MyPowTest()
        {
            var s = new Solution();
            Assert.AreEqual(4, s.MyPow(2, 2));
            Assert.AreEqual(16, s.MyPow(2, 4));
            Assert.AreEqual(0.5, s.MyPow(2, -1));
            Assert.AreEqual(0.25, s.MyPow(2, -2));
        }
    }
}

namespace TrappingRainWater.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void TrapTest()
        {
            var s = new Solution();
            Assert.AreEqual(9, s.Trap(new int[] { 4, 2, 0, 3, 2, 5 }));
            Assert.AreEqual(6, s.Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }));
        }
    }
}

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