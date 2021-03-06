﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinarySearch_AThayn;
using System.Collections.Generic;

namespace BinarySearchTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ChopLoopTest()
        {
            Chop chopper = new Chop();

            Assert.AreEqual(-1, chopper.ChopLoop(3, new List<int>{}));
            Assert.AreEqual(-1, chopper.ChopLoop(3, new List<int>{1}));
            Assert.AreEqual(0, chopper.ChopLoop(1, new List<int>{1}));
            
            Assert.AreEqual(0, chopper.ChopLoop(1, new List<int>{1, 3, 5}));
            Assert.AreEqual(1, chopper.ChopLoop(3, new List<int>{1, 3, 5}));
            Assert.AreEqual(2, chopper.ChopLoop(5, new List<int>{1, 3, 5}));
            Assert.AreEqual(-1, chopper.ChopLoop(0, new List<int>{1, 3, 5}));
            Assert.AreEqual(-1, chopper.ChopLoop(2, new List<int>{1, 3, 5}));
            Assert.AreEqual(-1, chopper.ChopLoop(4, new List<int>{1, 3, 5}));
            Assert.AreEqual(-1, chopper.ChopLoop(6, new List<int>{1, 3, 5}));
            
            Assert.AreEqual(0, chopper.ChopLoop(1, new List<int>{1, 3, 5, 7}));
            Assert.AreEqual(1, chopper.ChopLoop(3, new List<int>{1, 3, 5, 7}));
            Assert.AreEqual(2, chopper.ChopLoop(5, new List<int>{1, 3, 5, 7}));
            Assert.AreEqual(3, chopper.ChopLoop(7, new List<int>{1, 3, 5, 7}));
            Assert.AreEqual(-1, chopper.ChopLoop(0, new List<int>{1, 3, 5, 7}));
            Assert.AreEqual(-1, chopper.ChopLoop(2, new List<int>{1, 3, 5, 7}));
            Assert.AreEqual(-1, chopper.ChopLoop(4, new List<int>{1, 3, 5, 7}));
            Assert.AreEqual(-1, chopper.ChopLoop(6, new List<int>{1, 3, 5, 7}));
            Assert.AreEqual(-1, chopper.ChopLoop(8, new List<int>{1, 3, 5, 7}));
        }

        [TestMethod]
        public void ChopRecursionTest()
        {
            Chop chopper = new Chop();

            Assert.AreEqual(-1, chopper.ChopRecursion(3, new List<int> { }));
            Assert.AreEqual(-1, chopper.ChopRecursion(3, new List<int> { 1 }));
            Assert.AreEqual(0, chopper.ChopRecursion(1, new List<int> { 1 }));

            Assert.AreEqual(0, chopper.ChopRecursion(1, new List<int> { 1, 3, 5 }));
            Assert.AreEqual(1, chopper.ChopRecursion(3, new List<int> { 1, 3, 5 }));
            Assert.AreEqual(2, chopper.ChopRecursion(5, new List<int> { 1, 3, 5 }));
            Assert.AreEqual(-1, chopper.ChopRecursion(0, new List<int> { 1, 3, 5 }));
            Assert.AreEqual(-1, chopper.ChopRecursion(2, new List<int> { 1, 3, 5 }));
            Assert.AreEqual(-1, chopper.ChopRecursion(4, new List<int> { 1, 3, 5 }));
            Assert.AreEqual(-1, chopper.ChopRecursion(6, new List<int> { 1, 3, 5 }));

            Assert.AreEqual(0, chopper.ChopRecursion(1, new List<int> { 1, 3, 5, 7 }));
            Assert.AreEqual(1, chopper.ChopRecursion(3, new List<int> { 1, 3, 5, 7 }));
            Assert.AreEqual(2, chopper.ChopRecursion(5, new List<int> { 1, 3, 5, 7 }));
            Assert.AreEqual(3, chopper.ChopRecursion(7, new List<int> { 1, 3, 5, 7 }));
            Assert.AreEqual(-1, chopper.ChopRecursion(0, new List<int> { 1, 3, 5, 7 }));
            Assert.AreEqual(-1, chopper.ChopRecursion(2, new List<int> { 1, 3, 5, 7 }));
            Assert.AreEqual(-1, chopper.ChopRecursion(4, new List<int> { 1, 3, 5, 7 }));
            Assert.AreEqual(-1, chopper.ChopRecursion(6, new List<int> { 1, 3, 5, 7 }));
            Assert.AreEqual(-1, chopper.ChopRecursion(8, new List<int> { 1, 3, 5, 7 }));
        }

        [TestMethod]
        public void ChopChopChopChopTest()
        {
            Chop chopper = new Chop();

            Assert.AreEqual(-1, chopper.ChopChopChopChop(3, new List<int> { }));
            Assert.AreEqual(-1, chopper.ChopChopChopChop(3, new List<int> { 1 }));
            Assert.AreEqual(0, chopper.ChopChopChopChop(1, new List<int> { 1 }));

            Assert.AreEqual(0, chopper.ChopChopChopChop(1, new List<int> { 1, 3, 5 }));
            Assert.AreEqual(1, chopper.ChopChopChopChop(3, new List<int> { 1, 3, 5 }));
            Assert.AreEqual(2, chopper.ChopChopChopChop(5, new List<int> { 1, 3, 5 }));
            Assert.AreEqual(-1, chopper.ChopChopChopChop(0, new List<int> { 1, 3, 5 }));
            Assert.AreEqual(-1, chopper.ChopChopChopChop(2, new List<int> { 1, 3, 5 }));
            Assert.AreEqual(-1, chopper.ChopChopChopChop(4, new List<int> { 1, 3, 5 }));
            Assert.AreEqual(-1, chopper.ChopChopChopChop(6, new List<int> { 1, 3, 5 }));

            Assert.AreEqual(0, chopper.ChopChopChopChop(1, new List<int> { 1, 3, 5, 7 }));
            Assert.AreEqual(1, chopper.ChopChopChopChop(3, new List<int> { 1, 3, 5, 7 }));
            Assert.AreEqual(2, chopper.ChopChopChopChop(5, new List<int> { 1, 3, 5, 7 }));
            Assert.AreEqual(3, chopper.ChopChopChopChop(7, new List<int> { 1, 3, 5, 7 }));
            Assert.AreEqual(-1, chopper.ChopChopChopChop(0, new List<int> { 1, 3, 5, 7 }));
            Assert.AreEqual(-1, chopper.ChopChopChopChop(2, new List<int> { 1, 3, 5, 7 }));
            Assert.AreEqual(-1, chopper.ChopChopChopChop(4, new List<int> { 1, 3, 5, 7 }));
            Assert.AreEqual(-1, chopper.ChopChopChopChop(6, new List<int> { 1, 3, 5, 7 }));
            Assert.AreEqual(-1, chopper.ChopChopChopChop(8, new List<int> { 1, 3, 5, 7 }));
        }

        [TestMethod]
        public void ChopRecursionDifferently()
        {
            Chop chopper = new Chop();

            Assert.AreEqual(-1, chopper.ChopRecursionDifferently(3, new List<int> { }));
            Assert.AreEqual(-1, chopper.ChopRecursionDifferently(3, new List<int> { 1 }));
            Assert.AreEqual(0, chopper.ChopRecursionDifferently(1, new List<int> { 1 }));

            Assert.AreEqual(0, chopper.ChopRecursionDifferently(1, new List<int> { 1, 3, 5 }));
            Assert.AreEqual(1, chopper.ChopRecursionDifferently(3, new List<int> { 1, 3, 5 }));
            Assert.AreEqual(2, chopper.ChopRecursionDifferently(5, new List<int> { 1, 3, 5 }));
            Assert.AreEqual(-1, chopper.ChopRecursionDifferently(0, new List<int> { 1, 3, 5 }));
            Assert.AreEqual(-1, chopper.ChopRecursionDifferently(2, new List<int> { 1, 3, 5 }));
            Assert.AreEqual(-1, chopper.ChopRecursionDifferently(4, new List<int> { 1, 3, 5 }));
            Assert.AreEqual(-1, chopper.ChopRecursionDifferently(6, new List<int> { 1, 3, 5 }));

            Assert.AreEqual(0, chopper.ChopRecursionDifferently(1, new List<int> { 1, 3, 5, 7 }));
            Assert.AreEqual(1, chopper.ChopRecursionDifferently(3, new List<int> { 1, 3, 5, 7 }));
            Assert.AreEqual(2, chopper.ChopRecursionDifferently(5, new List<int> { 1, 3, 5, 7 }));
            Assert.AreEqual(3, chopper.ChopRecursionDifferently(7, new List<int> { 1, 3, 5, 7 }));
            Assert.AreEqual(-1, chopper.ChopRecursionDifferently(0, new List<int> { 1, 3, 5, 7 }));
            Assert.AreEqual(-1, chopper.ChopRecursionDifferently(2, new List<int> { 1, 3, 5, 7 }));
            Assert.AreEqual(-1, chopper.ChopRecursionDifferently(4, new List<int> { 1, 3, 5, 7 }));
            Assert.AreEqual(-1, chopper.ChopRecursionDifferently(6, new List<int> { 1, 3, 5, 7 }));
            Assert.AreEqual(-1, chopper.ChopRecursionDifferently(8, new List<int> { 1, 3, 5, 7 }));
        }
    }
}
