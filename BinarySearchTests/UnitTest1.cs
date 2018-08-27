﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinarySearchTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            assert_equal(-1, chop(3, []))
            assert_equal(-1, chop(3, [1]))
            assert_equal(0, chop(1, [1]))
            #
            assert_equal(0, chop(1, [1, 3, 5]))
            assert_equal(1, chop(3, [1, 3, 5]))
            assert_equal(2, chop(5, [1, 3, 5]))
            assert_equal(-1, chop(0, [1, 3, 5]))
            assert_equal(-1, chop(2, [1, 3, 5]))
            assert_equal(-1, chop(4, [1, 3, 5]))
            assert_equal(-1, chop(6, [1, 3, 5]))
            #
            assert_equal(0, chop(1, [1, 3, 5, 7]))
            assert_equal(1, chop(3, [1, 3, 5, 7]))
            assert_equal(2, chop(5, [1, 3, 5, 7]))
            assert_equal(3, chop(7, [1, 3, 5, 7]))
            assert_equal(-1, chop(0, [1, 3, 5, 7]))
            assert_equal(-1, chop(2, [1, 3, 5, 7]))
            assert_equal(-1, chop(4, [1, 3, 5, 7]))
            assert_equal(-1, chop(6, [1, 3, 5, 7]))
            assert_equal(-1, chop(8, [1, 3, 5, 7]))
        }
    }
}
