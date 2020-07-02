using LeetCode.Code;
using LeetCode.Code.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests
{
    [TestClass]
    public class Prob1365Test
    {
//        Input: nums = [8,1,2,2,3]
//        Output: [4,0,1,1,3]
//        Explanation: 
//For nums[0] = 8 there exist four smaller numbers than it(1, 2, 2 and 3). 
//For nums[1] = 1 does not exist any smaller number than it.
//  For nums[2]= 2 there exist one smaller number than it (1). 
//For nums[3] = 2 there exist one smaller number than it(1). 
//For nums[4] = 3 there exist three smaller numbers than it(1, 2 and 2).

        [TestMethod]
        public void ThereShouldReturn_40113()
        {
            var p = new Prob1365();
            
            var result = p.SmallerNumbersThanCurrent(new[] { 8, 1, 2, 2, 3 });
            CollectionAssert.AreEquivalent(new[] { 4, 0, 1, 1, 3 }, result);
        }

        [TestMethod]
        public void ThereShouldReturn_2103()
        {
            //Input: nums = [6, 5, 4, 8]
            //Output: [2, 1, 0, 3]
            var p = new Prob1365();
            var result = p.SmallerNumbersThanCurrent(new[] { 6, 5, 4, 8 });

            CollectionAssert.AreEquivalent(new[] { 2, 1, 0, 3 }, result);

        }

        [TestMethod]
        public void ThereShouldReturn_0000()
        {
            //Input: nums = [7, 7, 7, 7]
            //Output: [0, 0, 0, 0]
            var p = new Prob1365();
            var result = p.SmallerNumbersThanCurrent(new[] { 7, 7, 7, 7 });

            CollectionAssert.AreEquivalent(new[] { 0, 0, 0, 0 }, result);
        }
    }
}
