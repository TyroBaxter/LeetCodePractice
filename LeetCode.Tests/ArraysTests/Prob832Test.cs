using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Code.Arrays;

namespace LeetCode.Tests.ArraysTests
{
    [TestClass]
    public class Prob832Test
    {
        [TestMethod]
        public void It_should_return_100_010_111()
        {
            //Input: [[1, 1, 0],[1,0,1],[0,0,0]]
            //Output: [[1,0,0],[0,1,0],[1,1,1]]
            //Explanation: First reverse each row: [[0,1,1],[1,0,1],[0,0,0]].
            //Then, invert the image: [[1,0,0],[0,1,0],[1,1,1]]
            var p = new Prob832();

            var result = p.FlipAndInvertImage(new int[][] {
                new int [] { 1, 1, 0},
                new int [] { 1, 0, 1},
                new int [] { 0, 0, 0}
            });

            CollectionAssert.AreEqual(result[0], new int[] { 1, 0, 0 });

            CollectionAssert.AreEqual(result[1], new int[] { 0, 1, 0 });

            CollectionAssert.AreEqual(result[2], new int[] { 1, 1, 1 });
            
        }

        [TestMethod]
        public void It_should_return_1100_0110_0001_1010()
        {
            //Input: [[1, 1, 0, 0],[1,0,0,1],[0,1,1,1],[1,0,1,0]]
            //Output: [[1,1,0,0],[0,1,1,0],[0,0,0,1],[1,0,1,0]]

            var p = new Prob832();

            var result = p.FlipAndInvertImage(new int[][]
            {
                new int[]{1,1,0,0},
                new int[]{1,0,0,1},
                new int[]{0,1,1,1},
                new int[]{1,0,1,0}
            });

            CollectionAssert.AreEqual(result[0], new int[] { 1, 1, 0, 0 });
            CollectionAssert.AreEqual(result[1], new int[] { 0, 1, 1, 0 });
            CollectionAssert.AreEqual(result[2], new int[] { 0, 0, 0, 1 });
            CollectionAssert.AreEqual(result[3], new int[] { 1, 0, 1, 0 });
        }
    }
}
