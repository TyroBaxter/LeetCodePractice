//using System;
//using System.Collections.Generic;
//using System.Text;
//using LeetCode.Code.Recursion;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace LeetCode.Tests.RecursionTests
//{
//    [TestClass]
//    public class Prob938Test
//    {
//        //Input: root = [10,5,15,3,7,null,18], L = 7, R = 15
//        //Output: 32

//        [TestMethod]
//        public void It_should_return_32()
//        {
//            var p = new Prob938();

//            var result = p.RangeSumBST(new TreeNode[10, 5, 15, 3, 7, null, 18], 7, 15);

//            Assert.AreEqual(result, 32);
//        }

//        //Input: root = [10,5,15,3,7,13,18,1,null,6], L = 6, R = 10
//        //Output: 23
//        [TestMethod]
//        public void It_should_return_23()
//        {
//            var p = new Prob938();

//            var result = p.RangeSumBST(new TreeNode([10, 5, 15, 3, 7, 13, 18, 1, null, 6], 6, 10));

//            Assert.AreEqual(result, 23);
//        }
//    }
//}
